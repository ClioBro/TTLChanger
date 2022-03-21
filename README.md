# TTLChanger

Для скрытия от оператора раздачи «Мобильная точка доступа».

Wikipedia: -"Контроль TTL часто используются провайдерами для обнаружения трафика подключенного устройства. 
К примеру, если на смартфоне включить режим «Мобильная точка доступа» (тетеринг), TTL от подключенных устройств будет на 1 меньше ожидаемого. 
Тем самым блокируется доступ для этих устройств."


## MainPage
Если включена раздача со смартфона, выбрать значение 65 
| Демонстрация |
|--------------|
| ![Android Screenshot](https://github.com/ClioBro/TTLChanger/blob/main/art/TTLChangerImage.png) | 

### Changed TTL
Изменяется значение DefaultTTL в реестре.
Путь:

IPv4 - HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\Tcpip\Parameters.

IPv6 - HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\Tcpip6\Parameters.
| Демонстрация |
|--------------|
| ![Android Screenshot](https://github.com/ClioBro/TTLChanger/blob/main/art/DefaultTTLScreen.png) | 

## DopInfo

Для того что бы изменения пришли в силу, необходимо перезагрузить ПК. Вы можете без вреда удалять данный DefaultTTL.
