using ClioOFF.ComputerShotdownControl;
using System;
using System.Security;
using System.Windows.Forms;
using PcTTLChanger;
using PcTTLChanger.IPvChangerResources;
using PcTTLChanger.IPvChangerResources.interfaces;

namespace ClioOFF
{
    public partial class MainForm : Form, IWindowsFormTTLChangerView
    {
        private readonly IIPvItemsList _ipvItemList = new IPvItemsList();
        private readonly Controller _controller;

        public IIPvItem IPvItem => Chk_IPv.SelectedItem as IIPvItem;
        public short TTL => Convert.ToInt16(Chk_ttl.Text);
        public ulong Hours => Convert.ToUInt32(Chk_h);
        public ulong Minutes => Convert.ToUInt32(Chk_m);
        public ulong Seconds => Convert.ToUInt32(Chk_s);

        public MainForm() 
        {
            InitializeComponent();
            _controller = new Controller(this, new IPvOperator());

            Chk_IPv.DataSource = _ipvItemList.IPvItems;
            Chk_IPv.DisplayMember = nameof(IPvItem.Name);
        }
        public void ShowCurrentTTLStats(string stats) => ShowMessage(stats);
        private void ShowMessage(string message, string caption = "Message:") => MessageBox.Show(message, caption);

        private void SetTTL128(object sender, EventArgs e) => Chk_ttl.Text = "128";
        private void SetTTL65(object sender, EventArgs e) => Chk_ttl.Text = "65";

        private void ShutdownPC(object sender, EventArgs e) => StartTimerShutdownOperation(new PcShutdown());
        private void RebootPC(object sender, EventArgs e) => StartTimerShutdownOperation(new PcReboot());
        private void StartTimerShutdownOperation(BasePcOFFTimer pcShutdown)
        {
            ulong seconds = new CalculateTime(Hours, Minutes, Seconds).CalculateInSeconds();
            pcShutdown.SetTimer(seconds);
            pcShutdown.StartProcess();
        }
        
        private void ApplyValueTTL(object sender, EventArgs e)
        {
            try
            {
                _controller.ChangeTTL();

                ShowMessage($"{IPvItem.Name} DefaultTTL изменен(ы) на: {TTL}\n" +
                $"Что бы изменения вступили в силу, необходимо перезагрузить ОС");
            }
            catch (SecurityException) 
            {
                ShowMessage($"Запусти от имени Администратора.", "Error !"); 
            }
            catch (ObjectDisposedException x)
            {
                ShowMessage($"Раздел RegistryKey является закрытым (доступ к закрытым разделам невозможен).\n" +
                $"{x}", "Error !");
            }
            catch (IPvTTLValueException x)
            {
                ShowMessage($"{x.Message}\nВходящее значение: {x.Value}", "Error !");
            }
            catch (Exception x)
            {
                ShowMessage($"\n{x}\n" +
                    $"Если есть возможность, сообщите об ошибке разработчику.", "Error !");
            }
        }
        
        private void ShowCurrentTTLStats(object sender, EventArgs e) => _controller.ShowTTLStats();
        
        private void GoToGitHub(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/ClioBro");
        }
        
    }
}
