1. DB 배포 순서

 - dotnet ef migrations add {Migration Name} --project Portfolio
 - dotnet ef database update --project Portfolio

------------------------------

2. 서비스 배포 순서

 - 게시
 - Azure App Service (세팅 필요)

------------------------------

https://sgparkportfolio.azurewebsites.net/