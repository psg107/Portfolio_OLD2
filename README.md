1. 사전 준비
 - dotnet ef 설치 (powershell 에서 'dotnet tool install --global dotnet-ef' 입력)
 - connectionString이 있는 appsettings.json 준비
 - azuer - 즐겨찾기 - sgpark(SQL Server) - 보안 - 네트워킹 - 방화벽 규칙 - 클라이언트 IPv4 주소 추가


2. DB 배포 순서
 - dotnet ef migrations add {yyyyMMdd}\_{seq}\_{description} --project Portfolio
   - ex. dotnet ef migrations add 20240107_001_addProject --project Portfolio
 - dotnet ef database update --project Portfolio


3. 서비스 배포 순서
 - 게시
 - Azure App Service (세팅 필요)

------------------------------

https://sgparkportfolio.azurewebsites.net/
