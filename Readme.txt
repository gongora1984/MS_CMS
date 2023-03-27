Docker Compose Video:
https://www.youtube.com/watch?v=hpLvXNASyTI

Docker SQL Server Command
docker run -e "ACCEPT_EULA=Y" -e "MSSQL_SA_PASSWORD=0r4cl3HGC" -e "MSSQL_PID=Express" -p 8002:1433 -d mcr.microsoft.com/mssql/server:2022-latest