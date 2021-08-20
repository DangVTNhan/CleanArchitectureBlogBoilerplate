docker volume create sqlserver_volumn

docker run -d -e 'ACCEPT_EULA=Y' --name sqlserver -e 'SA_PASSWORD=Password123' -p 1433:1433 -v sqlserver_volumn:/var/opt/mssql 62c

Stupid window config !!!
net stop winnat
net start winnat

add-migration <name>
update-database
