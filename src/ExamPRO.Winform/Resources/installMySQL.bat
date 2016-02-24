
cls
 
echo Starting MySQL mysql-5.5.44-win32 install
msiexec /i "mysql-5.5.44-win32.msi" /passive
echo MySQLmysql-5.5.44-win32 installed successfully
 
echo Creating MySQL Windows service
"C:\Program Files (x86)\MySQL\MySQL Server 5.5\bin\mysqlinstanceconfig.exe" -i -q ServiceName="MySQL service" RootPassword="t5u8y67" ServerType=SERVER DatabaseType=MYISAM Port=3306 RootCurrentPassword=mysql
echo MySQL Instance Configured. Service started.

pause