Docker Compose Video:
https://www.youtube.com/watch?v=hpLvXNASyTI

Docker Compose Commands:
 - Start
	docker-compose up
 Stop
	docker-compose down

Docker SQL Server Command
docker run -e "ACCEPT_EULA=Y" -e "MSSQL_SA_PASSWORD=0r4cl3HGC" -e "MSSQL_PID=Express" -p 8002:1433 -d mcr.microsoft.com/mssql/server:2022-latest


Docker Command:
 - Build Image:
	docker build -t <<app_tag>> .
	ex: docker build -t mailingsystem .
 
 - Run Image into Container
	docker run -p externalport:internalport <<app_tag>>
	ex: docker run -p 8080:80 mailingsystem