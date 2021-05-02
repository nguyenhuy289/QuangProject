netsh advfirewall firewall delete rule name= "Open Port 1433 In" protocol=TCP localport=1433

netsh advfirewall firewall delete rule name= "Open Port 1433 Out" protocol=TCP localport=1433

netsh advfirewall firewall delete rule name= "Open Port 80 In" protocol=TCP localport=80

netsh advfirewall firewall delete rule name= "Open Port 80 Out" protocol=TCP localport=80

netsh advfirewall firewall delete rule name= "Open Port 6030 In" protocol=TCP localport=6030

netsh advfirewall firewall delete rule name= "Open Port 6030 Out" protocol=TCP localport=6030

netsh advfirewall firewall delete rule name= "Open Port 7979 In" protocol=TCP localport=7979

netsh advfirewall firewall delete rule name= "Open Port 7979 Out" protocol=TCP localport=7979

ping -n 5 127.0.0.1 >NUL

netsh advfirewall firewall add rule name="Open Port 1433 In" dir=in action=allow protocol=TCP localport=1433

netsh advfirewall firewall add rule name="Open Port 1433 Out" dir=out action=allow protocol=TCP localport=1433

netsh advfirewall firewall add rule name="Open Port 80 In" dir=in action=allow protocol=TCP localport=80

netsh advfirewall firewall add rule name="Open Port 80 Out" dir=out action=allow protocol=TCP localport=80

netsh advfirewall firewall add rule name="Open Port 6030 In" dir=in action=allow protocol=TCP localport=6030

netsh advfirewall firewall add rule name="Open Port 6030 Out" dir=out action=allow protocol=TCP localport=6030

netsh advfirewall firewall add rule name="Open Port 7979 In" dir=in action=allow protocol=TCP localport=7979

netsh advfirewall firewall add rule name="Open Port 7979 Out" dir=out action=allow protocol=TCP localport=7979


