using Portfolio.Entities;
using Portfolio.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Portfolio.Context
{
    public static class PortfolioDbContextSeed
    {
#warning custom attribute를 통해 이름을 자유롭게 설정할 수 있도록 처리 필요
        private enum Skill
        {
            /// <summary> </summary>
            CSharp,

            /// <summary> </summary>
            WPF,

            /// <summary> </summary>
            EntityFramework,

            /// <summary> </summary>
            Regex,

            /// <summary> </summary>
            OpenCV,

            /// <summary> </summary>
            Tesseract,

            /// <summary> </summary>
            Crawling,

            /// <summary> </summary>
            XPath,

            /// <summary> </summary>
            TelegramAPI,

            /// <summary> </summary>
            Dll,

            /// <summary> </summary>
            HwpAPI,

            /// <summary> </summary>
            RestAPI,

            /// <summary> </summary>
            AspDotNet,

            /// <summary> </summary>
            AspDotNetWebAPI,

            /// <summary> </summary>
            AspDotNetMVC,

            /// <summary> </summary>
            AutoHotkey,

            /// <summary> </summary>
            AutoHotkeyGUI,

            /// <summary> </summary>
            AndroidEmulator,

            /// <summary> </summary>
            PushbulletAPI,

            /// <summary> </summary>
            SendMessage,

            /// <summary> </summary>
            Console,

            /// <summary> </summary>
            Selenium,

            /// <summary> </summary>
            Sqlite,

            /// <summary> </summary>
            Java,

            /// <summary> </summary>
            Html,

            /// <summary> </summary>
            Css,

            /// <summary> </summary>
            Javascript,

            /// <summary> </summary>
            Jsp,

            /// <summary> </summary>
            Servlet,

            /// <summary> </summary>
            Mysql,

            /// <summary> </summary>
            MSSQL,

            /// <summary> </summary>
            OpenProxy,

            /// <summary> </summary>
            MultiThreading,

            /// <summary> </summary>
            Php,

            /// <summary> </summary>
            Android,

            /// <summary> </summary>
            AndroidWebView,

            /// <summary> </summary>
            OpenAPI,

            /// <summary> </summary>
            Xamarin,

            /// <summary> </summary>
            IOS,

            /// <summary> </summary>
            Firebase,

            /// <summary> </summary>
            FirebaseNotification,

            /// <summary> </summary>
            FirebaseRemoteConfig,

            /// <summary> </summary>
            DevexpressWPF,

            /// <summary> </summary>
            SignalR,

            /// <summary> </summary>
            CentOS,

            /// <summary> </summary>
            NaverCloudPlatform,

            /// <summary> </summary>
            JWT,

            /// <summary> </summary>
            ClassicASP,

            /// <summary> </summary>
            Blazor,

            /// <summary> </summary>
            Bootstrap,

            /// <summary> </summary>
            JQuery,

            /// <summary> </summary>
            Razor,

            /// <summary> </summary>
            BLE,
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static (List<Entities.SkillEntity> skills, List<ProjectEntity> projects, List<ProjectSkillEntity> projectSkills) GenerateData()
        {
            //스킬
            var skillIndex = 1;
            var skills = Enum.GetValues(typeof(Skill)).Cast<Skill>().Select(x => new SkillEntity
            {
                SkillId = skillIndex++,
                Name = x.ToString()
            }).ToList();

            //스킬 상세 정보 (안넣을수도)

            //프로젝트
            var projectIndex = 1;
            var projectSkillMatchers = new List<ProjectSkillMatcher>
            {
                new ProjectSkillMatcher
                {
                    Project = new ProjectEntity
                    {
                        ProjectId = projectIndex++,
                        Name = "로그 뷰어",
                        Description = "" +
                            "log4net를 이용하여 기록한 웹서비스 로그 파일을 확인하기 위한 프로그램입니다.\n\n" +
                            "로그 파일을 읽은 후 파싱하여 화면에 출력하며 다양한 검색 조건을 통해 원하는 결과를 얻을 수 있습니다.",
                        ProjectType = ProjectType.Company,
                        CreateYear = 2018,
                        SourceUrl = null,
                        IsHiddenSourceUrl = true,
                        IsHidden = false,
                        ReferenceUrl = null,
                    },
                    Skills = new List<SkillEntity>
                    {
                        skills.SingleOrDefault(x => x.Name == Skill.CSharp.ToString()),
                        skills.SingleOrDefault(x => x.Name == Skill.WPF.ToString()),
                        skills.SingleOrDefault(x => x.Name == Skill.Regex.ToString()),
                    }
                },
                new ProjectSkillMatcher
                {
                    Project = new ProjectEntity
                    {
                        ProjectId = projectIndex++,
                        Name = "한글 도움말 문서 분리 프로그램",
                        Description = "HWP 포맷으로 제작한 문서를 챕터별로 나누어진 여러 개의 HTML 파일로 변환 및 가공하는 프로그램입니다.",
                        ProjectType = ProjectType.Company,
                        CreateYear = 2019,
                        SourceUrl = null,
                        IsHiddenSourceUrl = true,
                        IsHidden = false,
                        ReferenceUrl = null,
                    },
                    Skills = new List<SkillEntity>
                    {
                        skills.SingleOrDefault(x => x.Name == Skill.CSharp.ToString()),
                        skills.SingleOrDefault(x => x.Name == Skill.WPF.ToString()),
                        skills.SingleOrDefault(x => x.Name == Skill.XPath.ToString()),
                        skills.SingleOrDefault(x => x.Name == Skill.Regex.ToString()),
                        skills.SingleOrDefault(x => x.Name == Skill.Css.ToString()),
                    }
                },
                new ProjectSkillMatcher
                {
                    Project = new ProjectEntity
                    {
                        ProjectId = projectIndex++,
                        Name = "프로그램 도움말 웹 페이지",
                        Description = "" +
                            "회사 프로그램 사용 방법을 안내하기 위한 도움말 페이지입니다.\n\n" +
                            "'한글 도움말 문서 분리 프로그램'로 생성한 여러 문서 중 사용자가 요청하는 페이지에 해당하는 문서가 표시되며 검색을 통해 특정 키워드가 포함된 문서를 찾을 수 있습니다.",
                        ProjectType = ProjectType.Company,
                        CreateYear = 2019,
                        SourceUrl = null,
                        IsHiddenSourceUrl = true,
                        IsHidden = false,
                        ReferenceUrl = null,
                    },
                    Skills = new List<SkillEntity>
                    {
                        skills.SingleOrDefault(x => x.Name == Skill.CSharp.ToString()),
                        skills.SingleOrDefault(x => x.Name == Skill.AspDotNetMVC.ToString()),
                    }
                },
                new ProjectSkillMatcher
                {
                    Project = new ProjectEntity
                    {
                        ProjectId = projectIndex++,
                        Name = "AutoCMS",
                        Description = "" +
                            "자동 CMS 출금을 위해 밴사별로 요구하는 데이터 생성 후 DLL 호출을 통해 계좌등록/출금신청 처리를 하는 프로그램입니다.\n\n" +
                            "데이터 송수신 및 결과에 따른 내부 DB 프로시저 호출을 통해 자동으로 출금이 이루어집니다.",
                        ProjectType = ProjectType.Company,
                        CreateYear = 2019,
                        SourceUrl = null,
                        IsHiddenSourceUrl = true,
                        IsHidden = false,
                        ReferenceUrl = null,
                    },
                    Skills = new List<SkillEntity>
                    {
                        skills.SingleOrDefault(x => x.Name == Skill.CSharp.ToString()),
                        skills.SingleOrDefault(x => x.Name == Skill.Console.ToString()),
                        skills.SingleOrDefault(x => x.Name == Skill.MSSQL.ToString()),
                        skills.SingleOrDefault(x => x.Name == Skill.Dll.ToString()),
                    }
                },
                new ProjectSkillMatcher
                {
                    Project = new ProjectEntity
                    {
                        ProjectId = projectIndex++,
                        Name = "CMSplus Mobile",
                        Description = "" +
                            "기존 운영하던 윈도우 어플리케이션의 모바일 버전입니다.\n\n" +
                            "자마린 프레임워크로 제작되었으며 웹서비스 호출 및 데이터 처리를 할 수 있습니다.",
                        ProjectType = ProjectType.Company,
                        CreateYear = 2018,
                        SourceUrl = null,
                        IsHiddenSourceUrl = true,
                        IsHidden = false,
                        ReferenceUrl = null,
                    },
                    Skills = new List<SkillEntity>
                    {
                        skills.SingleOrDefault(x => x.Name == Skill.CSharp.ToString()),
                        skills.SingleOrDefault(x => x.Name == Skill.Xamarin.ToString()),
                        skills.SingleOrDefault(x => x.Name == Skill.Android.ToString()),
                        skills.SingleOrDefault(x => x.Name == Skill.IOS.ToString()),
                        skills.SingleOrDefault(x => x.Name == Skill.Firebase.ToString()),
                        skills.SingleOrDefault(x => x.Name == Skill.FirebaseNotification.ToString()),
                        skills.SingleOrDefault(x => x.Name == Skill.FirebaseRemoteConfig.ToString()),
                        skills.SingleOrDefault(x => x.Name == Skill.Sqlite.ToString()),
                    }
                },
                new ProjectSkillMatcher
                {
                    Project = new ProjectEntity
                    {
                        ProjectId = projectIndex++,
                        Name = "CRM",
                        Description = "" +
                            "고객 관리를 위한 윈도우 어플리케이션입니다.\n\n" +
                            "WPF Devexpress로 제작되었으며 고객 관리를 위한 각종 기능이 포함되어 있습니다.\n\n" +
                            "- MSSQL 프로시저 호출을 통한 데이터 처리\n" +
                            "- 실시간 전화 알림 수신\n" +
                            "- 실시간 팩스 알림 수신\n" +
                            "- 외부 웹페이지 기능 호출\n" +
                            "- 웹 관리자 페이지 자동 로그인 및 인증 쿠키 관리\n" +
                            "- 메일 전송 / 프린팅 / 엑셀 / PDF 생성 기능\n" +
                            "- 검색 실수 보정 기능\n" +
                            "- 외부 클라이언트 자동화 기능",
                        ProjectType = ProjectType.Company,
                        CreateYear = 2019,
                        SourceUrl = null,
                        IsHiddenSourceUrl = true,
                        IsHidden = false,
                        ReferenceUrl = null,
                    },
                    Skills = new List<SkillEntity>
                    {
                        skills.SingleOrDefault(x => x.Name == Skill.CSharp.ToString()),
                        skills.SingleOrDefault(x => x.Name == Skill.WPF.ToString()),
                        skills.SingleOrDefault(x => x.Name == Skill.DevexpressWPF.ToString()),
                        skills.SingleOrDefault(x => x.Name == Skill.SignalR.ToString()),
                        skills.SingleOrDefault(x => x.Name == Skill.Crawling.ToString()),
                        skills.SingleOrDefault(x => x.Name == Skill.XPath.ToString()),
                        skills.SingleOrDefault(x => x.Name == Skill.Regex.ToString()),
                        skills.SingleOrDefault(x => x.Name == Skill.MSSQL.ToString()),
                    }
                },
                new ProjectSkillMatcher
                {
                    Project = new ProjectEntity
                    {
                        ProjectId = projectIndex++,
                        Name = "CRM WEB",
                        Description = "" +
                            "고객 관리를 위한 CRM 웹 어플리케이션입니다.\n\n" +
                            "SignalR을 이용한 전화 알림 및 DB 프로시저 호출을 통한 데이터 처리가 구현되었으며 윈도우 어플리케이션 방식으로 전환하면서 폐기되었습니다.",
                        ProjectType = ProjectType.Company | ProjectType.Deprecated,
                        CreateYear = 2019,
                        SourceUrl = null,
                        IsHiddenSourceUrl = true,
                        IsHidden = false,
                        ReferenceUrl = null,
                    },
                    Skills = new List<SkillEntity>
                    {
                        skills.SingleOrDefault(x => x.Name == Skill.CSharp.ToString()),
                        skills.SingleOrDefault(x => x.Name == Skill.AspDotNet.ToString()),
                        skills.SingleOrDefault(x => x.Name == Skill.AspDotNetMVC.ToString()),
                        skills.SingleOrDefault(x => x.Name == Skill.SignalR.ToString()),
                        skills.SingleOrDefault(x => x.Name == Skill.MSSQL.ToString()),
                    }
                },
                new ProjectSkillMatcher
                {
                    Project = new ProjectEntity
                    {
                        ProjectId = projectIndex++,
                        Name = "팩스 모니터링 클라이언트",
                        Description = "" +
                            "전자 팩스 에이전트를 실시간으로 모니터링하여 새로운 팩스가 도착하면 CRM 사용자에게 알림을 전송하는 프로그램입니다.\n\n" +
                            "또한 수신받은 tif 포맷의 팩스 이미지 파일을 png포맷으로 변환하여 다운로드할 수 있습니다.",
                        ProjectType = ProjectType.Company,
                        CreateYear = 2020,
                        SourceUrl = null,
                        IsHiddenSourceUrl = true,
                        IsHidden = false,
                        ReferenceUrl = null,
                    },
                    Skills = new List<SkillEntity>
                    {
                        skills.SingleOrDefault(x => x.Name == Skill.CSharp.ToString()),
                        skills.SingleOrDefault(x => x.Name == Skill.WPF.ToString()),
                        skills.SingleOrDefault(x => x.Name == Skill.SignalR.ToString()),
                    }
                },
                new ProjectSkillMatcher
                {
                    Project = new ProjectEntity
                    {
                        ProjectId = projectIndex++,
                        Name = "Classic ASP 웹페이지 유지보수",
                        Description = "Classic ASP로 작성된 웹페이지의 유지보수 작업입니다.",
                        ProjectType = ProjectType.Company,
                        CreateYear = 2018,
                        SourceUrl = null,
                        IsHiddenSourceUrl = true,
                        IsHidden = false,
                        ReferenceUrl = null,
                    },
                    Skills = new List<SkillEntity>
                    {
                        skills.SingleOrDefault(x => x.Name == Skill.CSharp.ToString()),
                        skills.SingleOrDefault(x => x.Name == Skill.ClassicASP.ToString()),
                        skills.SingleOrDefault(x => x.Name == Skill.Html.ToString()),
                        skills.SingleOrDefault(x => x.Name == Skill.Css.ToString()),
                        skills.SingleOrDefault(x => x.Name == Skill.Javascript.ToString()),
                    }
                },
                new ProjectSkillMatcher
                {
                    Project = new ProjectEntity
                    {
                        ProjectId = projectIndex++,
                        Name = "포트폴리오",
                        Description = "현재 보고있는 포트폴리오 페이지입니다.",
                        ProjectType = ProjectType.Private,
                        CreateYear = 2020,
                        SourceUrl = "https://github.com/psg107/Portfolio",
                        IsHiddenSourceUrl = false,
                        IsHidden = false,
                        ReferenceUrl = null,
                        ImageFilePath = "/images/project/pf.png"
                    },
                    Skills = new List<SkillEntity>
                    {
                        skills.SingleOrDefault(x => x.Name == Skill.CSharp.ToString()),
                        skills.SingleOrDefault(x => x.Name == Skill.AspDotNet.ToString()),
                        skills.SingleOrDefault(x => x.Name == Skill.Blazor.ToString()),
                        skills.SingleOrDefault(x => x.Name == Skill.EntityFramework.ToString()),
                        skills.SingleOrDefault(x => x.Name == Skill.Html.ToString()),
                        skills.SingleOrDefault(x => x.Name == Skill.Css.ToString()),
                        skills.SingleOrDefault(x => x.Name == Skill.Javascript.ToString()),
                        skills.SingleOrDefault(x => x.Name == Skill.MSSQL.ToString()),
                        skills.SingleOrDefault(x => x.Name == Skill.NaverCloudPlatform.ToString()),
                    }
                },
                new ProjectSkillMatcher
                {
                    Project = new ProjectEntity
                    {
                        ProjectId = projectIndex++,
                        Name = "뽐뿌 모니터링 텔레그램 봇",
                        Description = "" +
                            "쇼핑몰 핫딜을 공유하는 사이트인 뽐뿌의 게시판을 실시간으로 모니터링하는 텔레그램 봇입니다.\n\n" +
                            "텔레그램 메시지를 통해 알림을 받고 싶은 키워드를 등록할 수 있으며 해당 키워드가 포함된 새로운 글이 올라오면 푸시 알림이 전송됩니다.\n\n" +
                            "텔레그램에서 @BoardMonitorBot 을 추가하여 사용할 수 있습니다.\n" +
                            "(현재 서버 미실행으로 사용 불가)",
                        ProjectType = ProjectType.Private,
                        CreateYear = 2020,
                        SourceUrl = "https://github.com/psg107/TelegramMonitorServer",
                        IsHiddenSourceUrl = true,
                        IsHidden = false,
                        ReferenceUrl = null,
                        ImageFilePath = "/images/project/bbmonitor.png"
                    },
                    Skills = new List<SkillEntity>
                    {
                        skills.SingleOrDefault(x => x.Name == Skill.CSharp.ToString()),
                        skills.SingleOrDefault(x => x.Name == Skill.EntityFramework.ToString()),
                        skills.SingleOrDefault(x => x.Name == Skill.Crawling.ToString()),
                        skills.SingleOrDefault(x => x.Name == Skill.XPath.ToString()),
                        skills.SingleOrDefault(x => x.Name == Skill.TelegramAPI.ToString()),
                    }
                },
                new ProjectSkillMatcher
                {
                    Project = new ProjectEntity
                    {
                        ProjectId = projectIndex++,
                        Name = "인터파크 자동 티켓팅 (pc서버)",
                        Description = "" +
                            "인터파크 티켓팅 프로세스를 분석하여 제작한 자동 티켓 구매 프로그램입니다.\n\n" +
                            "로그인 쿠키 정보, 티켓 판매 주소, 공연 날짜 및 시간을 입력하면 해당 공연의 티켓을 무통장결제 방식으로 자동으로 구매하며 프로그램 작동 중 캡챠(매크로 방지)가 나타나면 자동으로 이미지를 인식하여 입력합니다.\n\n" +
                            "현재 모바일서버를 통한 자동 티켓팅 방식으로 마이그레이션 진행 중입니다.",
                        ProjectType = ProjectType.Private | ProjectType.Deprecated,
                        CreateYear = 2020,
                        SourceUrl = "https://github.com/psg107/InterparkTicketing",
                        IsHiddenSourceUrl = true,
                        IsHidden = false,
                        ReferenceUrl = null,
                        ImageFilePath = "/images/project/it.png"
                    },
                    Skills = new List<SkillEntity>
                    {
                        skills.SingleOrDefault(x => x.Name == Skill.CSharp.ToString()),
                        skills.SingleOrDefault(x => x.Name == Skill.WPF.ToString()),
                        skills.SingleOrDefault(x => x.Name == Skill.Crawling.ToString()),
                        skills.SingleOrDefault(x => x.Name == Skill.XPath.ToString()),
                        skills.SingleOrDefault(x => x.Name == Skill.Regex.ToString()),
                        skills.SingleOrDefault(x => x.Name == Skill.OpenCV.ToString()),
                        skills.SingleOrDefault(x => x.Name == Skill.Tesseract.ToString()),
                    }
                },
                new ProjectSkillMatcher
                {
                    Project = new ProjectEntity
                    {
                        ProjectId = projectIndex++,
                        Name = "인터파크 자동 티켓팅 (모바일서버)",
                        Description = "" +
                            "인터파크 티켓팅 프로세스를 분석하여 제작한 자동 티켓 구매 프로그램입니다.\n\n" +
                            "로그인 쿠키 정보, 티켓 판매 주소, 공연 날짜 및 시간을 입력하면 해당 공연의 티켓을 무통장결제 방식으로 자동으로 구매하며 프로그램 작동 중 캡챠(매크로 방지)가 나타나면 자동으로 이미지를 인식하여 입력합니다.\n\n" +
                            "현재 일부 기능이 구현되어 있지 않으며 기본적인 기능 구현 후 티켓 개수 선택 기능, 연석(붙어있는 자리) 판단 기능을 추가할 예정입니다.",
                        ProjectType = ProjectType.Private | ProjectType.Incomplete,
                        CreateYear = 2020,
                        SourceUrl = "https://github.com/psg107/InterparkTicketingM",
                        IsHiddenSourceUrl = true,
                        IsHidden = false,
                        ReferenceUrl = null,
                        ImageFilePath = "/images/project/itm.png"
                    },
                    Skills = new List<SkillEntity>
                    {
                        skills.SingleOrDefault(x => x.Name == Skill.CSharp.ToString()),
                        skills.SingleOrDefault(x => x.Name == Skill.WPF.ToString()),
                        skills.SingleOrDefault(x => x.Name == Skill.Crawling.ToString()),
                        skills.SingleOrDefault(x => x.Name == Skill.XPath.ToString()),
                        skills.SingleOrDefault(x => x.Name == Skill.Regex.ToString()),
                        skills.SingleOrDefault(x => x.Name == Skill.OpenCV.ToString()),
                        skills.SingleOrDefault(x => x.Name == Skill.Tesseract.ToString()),
                    }
                },
                new ProjectSkillMatcher
                {
                    Project = new ProjectEntity
                    {
                        ProjectId = projectIndex++,
                        Name = "c# hwp 컨트롤 dll",
                        Description = "" +
                            "c#으로 한글 문서를 컨트롤하기 위해 한글 오토메이션 API를 래핑한 c# dll입니다.\n\n" +
                            "현재 불러오기, 저장하기, pdf로 저장하기, 찾아바꾸기 기능이 구현되었습니다.",
                        ProjectType = ProjectType.Private | ProjectType.Incomplete,
                        CreateYear = 2020,
                        SourceUrl = "https://github.com/psg107/HwpSharp",
                        IsHiddenSourceUrl = true,
                        IsHidden = false,
                        ReferenceUrl = null,
                        ImageFilePath = "/images/project/hc.png"
                    },
                    Skills = new List<SkillEntity>
                    {
                        skills.SingleOrDefault(x => x.Name == Skill.CSharp.ToString()),
                        skills.SingleOrDefault(x => x.Name == Skill.Dll.ToString()),
                        skills.SingleOrDefault(x => x.Name == Skill.HwpAPI.ToString()),
                    }
                },
                new ProjectSkillMatcher
                {
                    Project = new ProjectEntity
                    {
                        ProjectId = projectIndex++,
                        Name = "모바일게임 매크로 프로그램 우회용 서버 (기존)",
                        Description = "" +
                            "매달 구독방식으로 판매하는 모바일게임 사설 매크로의 로그인 인증을 우회하기 위한 서버입니다.\n\n" +
                            "hosts 파일을 변경하여 인증서버를 우회하는 방식으로 로그인을 우회합니다.\n\n" +
                            "현재 asp.net core로 새로 제작하여 현재 프로젝트는 더 이상 사용되지 않습니다.",
                        ProjectType = ProjectType.Private | ProjectType.Deprecated,
                        CreateYear = 2018,
                        SourceUrl = "https://github.com/psg107/HongMacroServerCrack",
                        IsHiddenSourceUrl = true,
                        IsHidden = false,
                        ReferenceUrl = null,
                        ImageFilePath = "/images/project/hongserverold.png"
                    },
                    Skills = new List<SkillEntity>
                    {
                        skills.SingleOrDefault(x => x.Name == Skill.CSharp.ToString()),
                        skills.SingleOrDefault(x => x.Name == Skill.RestAPI.ToString()),
                        skills.SingleOrDefault(x => x.Name == Skill.AspDotNet.ToString()),
                        skills.SingleOrDefault(x => x.Name == Skill.AspDotNetWebAPI.ToString()),
                    }
                },
                new ProjectSkillMatcher
                {
                    Project = new ProjectEntity
                    {
                        ProjectId = projectIndex++,
                        Name = "모바일게임 매크로 우회서버 (신규)",
                        Description = "" +
                            "매달 구독방식으로 판매하는 모바일게임 사설 매크로의 로그인 인증을 우회하기 위한 서버입니다.\n\n" +
                            "hosts 파일을 변경하여 인증서버를 우회하는 방식으로 로그인을 우회하며 데이터를 저장하기 위해 MSSQL 또는 Mysql을 사용할 수 있습니다.\n\n" +
                            "주기적으로 실제서버의 버전을 확인하여 동기화하는 기능이 포함되어 있습니다.",
                        ProjectType = ProjectType.Private,
                        CreateYear = 2020,
                        SourceUrl = "https://github.com/psg107/HongServer",
                        IsHiddenSourceUrl = true,
                        IsHidden = false,
                        ReferenceUrl = null,
                        ImageFilePath = "/images/project/hongserver.png"
                    },
                    Skills = new List<SkillEntity>
                    {
                        skills.SingleOrDefault(x => x.Name == Skill.CSharp.ToString()),
                        skills.SingleOrDefault(x => x.Name == Skill.RestAPI.ToString()),
                        skills.SingleOrDefault(x => x.Name == Skill.AspDotNet.ToString()),
                        skills.SingleOrDefault(x => x.Name == Skill.AspDotNetWebAPI.ToString()),
                        skills.SingleOrDefault(x => x.Name == Skill.EntityFramework.ToString()),
                        skills.SingleOrDefault(x => x.Name == Skill.MSSQL.ToString()),
                        skills.SingleOrDefault(x => x.Name == Skill.Mysql.ToString()),
                    }
                },
                new ProjectSkillMatcher
                {
                    Project = new ProjectEntity
                    {
                        ProjectId = projectIndex++,
                        Name = "모바일게임 매크로 업데이트 프로그램",
                        Description = "" +
                            "사설 매크로 로그인 서버를 우회하기 위해 hosts파일을 변조했더니 업데이트 서버도 같이 우회가 되어 공식 업데이트 프로그램이 작동하지 않아 다른 호스트를 통해 업데이트를 할 수 있도록 만든 윈도우 어플리케이션입니다.\n\n" +
                            "프로그램 버전 체크, 새로운 업데이트 파일 확인, 업데이트 파일 압축 해제 및 버전 갱신 기능이 포함되어 있습니다.",
                        ProjectType = ProjectType.Private,
                        CreateYear = 2018,
                        SourceUrl = "https://github.com/psg107/HongUpdater",
                        IsHiddenSourceUrl = true,
                        IsHidden = false,
                        ReferenceUrl = null,
                        ImageFilePath = "/images/project/hongupdater.png"
                    },
                    Skills = new List<SkillEntity>
                    {
                        skills.SingleOrDefault(x => x.Name == Skill.CSharp.ToString()),
                        skills.SingleOrDefault(x => x.Name == Skill.WPF.ToString()),
                    }
                },
                new ProjectSkillMatcher
                {
                    Project = new ProjectEntity
                    {
                        ProjectId = projectIndex++,
                        Name = "쿠팡 자동 결제 dll",
                        Description = "" +
                            "쿠팡에서 판매하는 물건을 자동으로 구매하기 위한 dll파일입니다.\n\n" +
                            "로그인 정보, 상품 주소를 입력하면 쿠팡 결제 프로세스를 동일하게 재현하여 자동으로 구매가 이루어지며 단기간에 구매요청을 많이 하는 경우 서버로부터 차단되는 문제로 인해 상품 모니터링은 별도의 외부 프로그램을 이용하도록 제작되었습니다.",
                        ProjectType = ProjectType.Private,
                        CreateYear = 2020,
                        SourceUrl = "https://github.com/psg107/CoupangPaymentLib",
                        IsHiddenSourceUrl = true,
                        IsHidden = false,
                        ReferenceUrl = null,
                        ImageFilePath = "/images/project/cp.png"
                    },
                    Skills = new List<SkillEntity>
                    {
                        skills.SingleOrDefault(x => x.Name == Skill.CSharp.ToString()),
                        skills.SingleOrDefault(x => x.Name == Skill.Dll.ToString()),
                        skills.SingleOrDefault(x => x.Name == Skill.Crawling.ToString()),
                        skills.SingleOrDefault(x => x.Name == Skill.XPath.ToString()),
                        skills.SingleOrDefault(x => x.Name == Skill.Regex.ToString()),
                    }
                },
                new ProjectSkillMatcher
                {
                    Project = new ProjectEntity
                    {
                        ProjectId = projectIndex++,
                        Name = "쿠팡 장바구니 모니터링",
                        Description = "" +
                            "쿠팡 장바구니에 담긴 물건의 재고를 확인하기 위해 안드로이드 에뮬레이터의 화면을 실시간으로 모니터링하는 프로그램입니다.\n\n" +
                            "마우스를 조작하여 안드로이드 에뮬레이터에서 실행중인 쿠팡의 장바구니를 지속적으로 새로고침하여 물건의 재고를 확인하며 재고가 생기면 자동 결제 dll을 호출 및 구매 버튼을 연타하여 무통장 방식으로 물건 구매 시도 후 휴대폰으로 알림을 전송합니다.\n\n" +
                            "최초에는 웹페이지 크롤링 방식으로 모니터링을 진행하였으나 단기간에 웹페이지로 많은 요청을 하는 경우 서버로부터 차단되는 문제로 인해 해결법을 찾는 중 모바일 어플리케이션은 단기간에 많은 요청을 하더라도 차단을 하지 않는다는 점을 확인하여 변경한 방식입니다.",
                        ProjectType = ProjectType.Private,
                        CreateYear = 2020,
                        SourceUrl = "https://github.com/psg107/CoupangMaskAHK",
                        IsHiddenSourceUrl = true,
                        IsHidden = false,
                        ReferenceUrl = null,
                        ImageFilePath = "/images/project/cpmonitorahk.png"
                    },
                    Skills = new List<SkillEntity>
                    {
                        skills.SingleOrDefault(x => x.Name == Skill.AutoHotkey.ToString()),
                        skills.SingleOrDefault(x => x.Name == Skill.AndroidEmulator.ToString()),
                        skills.SingleOrDefault(x => x.Name == Skill.PushbulletAPI.ToString()),
                    }
                },
                new ProjectSkillMatcher
                {
                    Project = new ProjectEntity
                    {
                        ProjectId = projectIndex++,
                        Name = "네이버 스토어 자동 구매",
                        Description = "" +
                            "네이버 스토어에서 판매하는 물건을 자동으로 구매하는 프로그램입니다.\n\n" +
                            "네이버 스토어의 링크를 입력하면 지속적으로 모니터링을 하여 재고가 생기는 순간 자동으로 구매를 진행하며 현재 구매 링크 생성까지 구현되었습니다.\n\n" +
                            "다만 상품을 구매하기 위해 모니터링 간격을 짧게 설정하면 네이버 서버에서 차단되고 간격을 길게 설정하면 상품이 품절되는 문제로 인해 생각보다 실용적이지 않아 개발을 중단하였습니다.",
                        ProjectType = ProjectType.Private | ProjectType.Incomplete | ProjectType.Deprecated,
                        CreateYear = 2020,
                        SourceUrl = "https://github.com/psg107/AutoNaverStore",
                        IsHiddenSourceUrl = true,
                        IsHidden = false,
                        ReferenceUrl = null,
                        ImageFilePath = "/images/project/naverstore.png"
                    },
                    Skills = new List<SkillEntity>
                    {
                        skills.SingleOrDefault(x => x.Name == Skill.CSharp.ToString()),
                        skills.SingleOrDefault(x => x.Name == Skill.WPF.ToString()),
                        skills.SingleOrDefault(x => x.Name == Skill.Crawling.ToString()),
                        skills.SingleOrDefault(x => x.Name == Skill.XPath.ToString()),
                        skills.SingleOrDefault(x => x.Name == Skill.Regex.ToString()),
                    }
                },
                new ProjectSkillMatcher
                {
                    Project = new ProjectEntity
                    {
                        ProjectId = projectIndex++,
                        Name = "코스트코 상품 모니터링",
                        Description = "코스트코 상품 판매 페이지를 모니터링하여 상품의 재고가 생기면 휴대폰으로 푸시 알림 및 카카오톡 메시지를 전송하는 프로그램입니다.",
                        ProjectType = ProjectType.Private | ProjectType.Incomplete,
                        CreateYear = 2020,
                        SourceUrl = "https://github.com/psg107/CostcoMonitor",
                        IsHiddenSourceUrl = true,
                        IsHidden = false,
                        ReferenceUrl = null
                    },
                    Skills = new List<SkillEntity>
                    {
                        skills.SingleOrDefault(x => x.Name == Skill.CSharp.ToString()),
                        skills.SingleOrDefault(x => x.Name == Skill.WPF.ToString()),
                        skills.SingleOrDefault(x => x.Name == Skill.Crawling.ToString()),
                        skills.SingleOrDefault(x => x.Name == Skill.XPath.ToString()),
                        skills.SingleOrDefault(x => x.Name == Skill.Regex.ToString()),
                        skills.SingleOrDefault(x => x.Name == Skill.SendMessage.ToString()),
                    }
                },
                new ProjectSkillMatcher
                {
                    Project = new ProjectEntity
                    {
                        ProjectId = projectIndex++,
                        Name = "쿠팡 상품 리스트 모니터링",
                        Description = "" +
                            "특정 검색어에 대한 검색 결과를 페이지별로 순회하여 모니터링하는 프로그램입니다.\n\n" +
                            "속도가 느려서 사용하지 않습니다.",
                        ProjectType = ProjectType.Private | ProjectType.Incomplete | ProjectType.Deprecated,
                        CreateYear = 2020,
                        SourceUrl = "https://github.com/psg107/CoupangMask",
                        IsHiddenSourceUrl = true,
                        IsHidden = false,
                        ReferenceUrl = null
                    },
                    Skills = new List<SkillEntity>
                    {
                        skills.SingleOrDefault(x => x.Name == Skill.CSharp.ToString()),
                        skills.SingleOrDefault(x => x.Name == Skill.Console.ToString()),
                        skills.SingleOrDefault(x => x.Name == Skill.Selenium.ToString()),
                        skills.SingleOrDefault(x => x.Name == Skill.PushbulletAPI.ToString()),
                    }
                },
                new ProjectSkillMatcher
                {
                    Project = new ProjectEntity
                    {
                        ProjectId = projectIndex++,
                        Name = "경북 교육행정포털 일정관리 윈도우 프로그램",
                        Description = "" +
                            "경북 교육행정포털 일정관리 프로그램의 기능 추가 및 개선 작업을 위해 약 2달간 진행한 프로젝트입니다.\n\n" +
                            "각종 기능 추가/변경 사항에 대한 UI작업, 서버 API 변경에 따른 대응, 엑셀/프린팅 등 각종 부가 기능 추가, 로컬DB 마이그레이션, 버그 수정 작업을 진행했습니다.",
                        ProjectType = ProjectType.Private,
                        CreateYear = 2020,
                        SourceUrl = null,
                        IsHiddenSourceUrl = true,
                        IsHidden = false,
                        ReferenceUrl = "http://www.info.go.kr/teacher/schedule/prodown/prodown.do",
                        ImageFilePath = "/images/project/info.jpg"
                    },
                    Skills = new List<SkillEntity>
                    {
                        skills.SingleOrDefault(x => x.Name == Skill.CSharp.ToString()),
                        skills.SingleOrDefault(x => x.Name == Skill.WPF.ToString()),
                        skills.SingleOrDefault(x => x.Name == Skill.RestAPI.ToString()),
                        skills.SingleOrDefault(x => x.Name == Skill.Sqlite.ToString()),
                    }
                },
                new ProjectSkillMatcher
                {
                    Project = new ProjectEntity
                    {
                        ProjectId = projectIndex++,
                        Name = "소프라노몰 자동 구매 프로그램",
                        Description = "" +
                            "소프라노몰이라는 온라인 쇼핑몰에서 판매하는 상품을 자동으로 구매하는 프로그램입니다.\n\n" +
                            "프로그램 제작 후 상품 판매시간에 작동을 해보았으나 디버깅을 위한 메시지박스를 제거하는 것을 깜빡하여 구매에 실패하였으며 이후 다른 사이트에서 원하는 상품을 구매하여 더 이상 관리를 하지 않습니다.",
                        ProjectType = ProjectType.Private | ProjectType.Incomplete,
                        CreateYear = 2020,
                        SourceUrl = "https://github.com/psg107/SofranoHelper",
                        IsHiddenSourceUrl = true,
                        IsHidden = false,
                        ReferenceUrl = null,
                        ImageFilePath = "/images/project/sofrano.png"
                    },
                    Skills = new List<SkillEntity>
                    {
                        skills.SingleOrDefault(x => x.Name == Skill.CSharp.ToString()),
                        skills.SingleOrDefault(x => x.Name == Skill.WPF.ToString()),
                        skills.SingleOrDefault(x => x.Name == Skill.Crawling.ToString()),
                        skills.SingleOrDefault(x => x.Name == Skill.XPath.ToString()),
                        skills.SingleOrDefault(x => x.Name == Skill.Regex.ToString()),
                    }
                },
                new ProjectSkillMatcher
                {
                    Project = new ProjectEntity
                    {
                        ProjectId = projectIndex++,
                        Name = "낚시터 컨셉 웹사이트",
                        Description = "" +
                            "낚시터를 컨셉으로 만든 웹 프로젝트입니다.\n\n" +
                            "대학교 졸업학기에 다닌 학원에서 jsp, 서블릿까지 배운 상태에서 진행한 중간 프로젝트로 mysql과 연동한 간단한 게시판 CRUD가 구현되어 있습니다.\n\n" +
                            "약 5명의 인원으로 진행하였으며 수강생의 대부분이 비전공자라 코드 작성보다는 프로젝트 관리 및 팀원 학습 위주로 진행하였습니다.",
                        ProjectType = ProjectType.Private,
                        CreateYear = 2018,
                        SourceUrl = "https://github.com/psg107/fishing",
                        IsHiddenSourceUrl = true,
                        IsHidden = false,
                        ReferenceUrl = null,
                    },
                    Skills = new List<SkillEntity>
                    {
                        skills.SingleOrDefault(x => x.Name == Skill.Java.ToString()),
                        skills.SingleOrDefault(x => x.Name == Skill.Html.ToString()),
                        skills.SingleOrDefault(x => x.Name == Skill.Css.ToString()),
                        skills.SingleOrDefault(x => x.Name == Skill.Javascript.ToString()),
                        skills.SingleOrDefault(x => x.Name == Skill.Jsp.ToString()),
                        skills.SingleOrDefault(x => x.Name == Skill.Servlet.ToString()),
                        skills.SingleOrDefault(x => x.Name == Skill.Mysql.ToString()),
                    }
                },
                new ProjectSkillMatcher
                {
                    Project = new ProjectEntity
                    {
                        ProjectId = projectIndex++,
                        Name = "모바일게임 리소스 다운로드 프로그램",
                        Description = "" +
                            "모바일 게임 패치 서버에서 업데이트 파일 다운로드 및 포맷별 자동 분류 프로그램입니다.\n\n" +
                            "패치 파일 압축 해제 후 이미지/텍스트/오디오 파일을 자동 분류하며 오픈소스를 활용하여 ktx포맷의 이미지를 png포맷으로 변환합니다.\n\n" +
                            "현재 코드를 정리하여 새로 제작하려고 계획중입니다.",
                        ProjectType = ProjectType.Private,
                        CreateYear = 2018,
                        SourceUrl = "https://github.com/psg107/SevenKnightsPatchPreviewer",
                        IsHiddenSourceUrl = true,
                        IsHidden = false,
                        ReferenceUrl = null,
                        ImageFilePath = "/images/project/sp.png"
                    },
                    Skills = new List<SkillEntity>
                    {
                        skills.SingleOrDefault(x => x.Name == Skill.CSharp.ToString()),
                        skills.SingleOrDefault(x => x.Name == Skill.WPF.ToString()),
                    }
                },
                new ProjectSkillMatcher
                {
                    Project = new ProjectEntity
                    {
                        ProjectId = projectIndex++,
                        Name = "유튜브 자동 조회수 증가 프로그램",
                        Description = "" +
                            "구글에 돌아다니는 오픈 프록시를 이용하여 유튜브 조회수를 올리려고 시도했던 프로젝트입니다.\n\n" +
                            "유튜브에서 어떤 방식으로 체크하는지 모르겠으나 일정 조회수 이상으로는 올라가지 않았습니다.\n\n" +
                            "유료 프록시를 이용하면 가능성이 있을 수 있으나 비용 대비 얻는게 없어서 제작을 중단했습니다.",
                        ProjectType = ProjectType.Private | ProjectType.Incomplete | ProjectType.Deprecated,
                        CreateYear = 2019,
                        SourceUrl = "https://github.com/psg107/YoutubeTest",
                        IsHiddenSourceUrl = true,
                        IsHidden = false,
                        ReferenceUrl = null,
                        ImageFilePath = "/images/project/yt.png"
                    },
                    Skills = new List<SkillEntity>
                    {
                        skills.SingleOrDefault(x => x.Name == Skill.CSharp.ToString()),
                        skills.SingleOrDefault(x => x.Name == Skill.WPF.ToString()),
                        skills.SingleOrDefault(x => x.Name == Skill.Selenium.ToString()),
                        skills.SingleOrDefault(x => x.Name == Skill.OpenProxy.ToString()),
                        skills.SingleOrDefault(x => x.Name == Skill.MultiThreading.ToString()),
                    }
                },
                new ProjectSkillMatcher
                {
                    Project = new ProjectEntity
                    {
                        ProjectId = projectIndex++,
                        Name = "모바일게임 매크로",
                        Description = "" +
                            "개인 취미로 만들었던 모바일 게임 매크로 프로그램입니다.\n\n" +
                            "게임 패치때마다 발생하는 유지보수 시간이 아까워서 다른 사람이 제작/판매하는 사설 매크로를 우회하여 사용하면서 제작을 중단했습니다.",
                        ProjectType = ProjectType.Private | ProjectType.Incomplete | ProjectType.Deprecated,
                        CreateYear = 2017,
                        SourceUrl = "https://github.com/psg107/SKMacro",
                        IsHiddenSourceUrl = true,
                        IsHidden = false,
                        ReferenceUrl = null,
                        ImageFilePath = "/images/project/skmacro.png"
                    },
                    Skills = new List<SkillEntity>
                    {
                        skills.SingleOrDefault(x => x.Name == Skill.AutoHotkey.ToString()),
                        skills.SingleOrDefault(x => x.Name == Skill.AutoHotkeyGUI.ToString()),
                        skills.SingleOrDefault(x => x.Name == Skill.AndroidEmulator.ToString()),
                    }
                },
                new ProjectSkillMatcher
                {
                    Project = new ProjectEntity
                    {
                        ProjectId = projectIndex++,
                        Name = "학교 출석페이지 접근 프로그램",
                        Description = "" +
                            "대학교를 다닐때 교수 출석 관리 페이지가 인증 과정없이 데이터만 맞춰주면 접근이 되길래 만들어본 프로그램입니다.\n\n" +
                            "학교 LMS에 있는 쪽지보내기의 검색 기능을 이용하여 교수 이름으로 교수 ID를 가져온 후 일부 추가 작업을 통해 해당 교수의 출석 관리 페이지가 열리도록 제작하였습니다.",
                        ProjectType = ProjectType.Private,
                        CreateYear = 2017,
                        SourceUrl = "https://github.com/psg107/DAttend",
                        IsHiddenSourceUrl = true,
                        IsHidden = false,
                        ReferenceUrl = null,
                        ImageFilePath = "/images/project/duattend.png"
                    },
                    Skills = new List<SkillEntity>
                    {
                        skills.SingleOrDefault(x => x.Name == Skill.AutoHotkey.ToString()),
                        skills.SingleOrDefault(x => x.Name == Skill.AutoHotkeyGUI.ToString()),
                        skills.SingleOrDefault(x => x.Name == Skill.Crawling.ToString()),
                    }
                },
                new ProjectSkillMatcher
                {
                    Project = new ProjectEntity
                    {
                        ProjectId = projectIndex++,
                        Name = "대학교 원격출석 프로그램",
                        Description = "" +
                            "QR코드 스캔 방식의 대학교 출석을 원격으로 하는 프로그램입니다." +
                            "강의실 고유키를 DB에 저장하여 관리하였으며 출석 요청시 미리 등록된 키를 통해 출석이 되도록 제작했습니다.\n\n" +
                            "최초에는 웹으로 제작하여 강의실과 학번을 직접 입력해야했으나 안드로이드 앱으로 변경하면서 로그인 기능 및 학교 LMS을 통한 시간표 조회 및 강의실 자동 인식 기능이 추가되었습니다.\n\n" +
                            "현재 소스 코드가 분실되어 일부 자료만 존재합니다.",
                        ProjectType = ProjectType.Private,
                        CreateYear = 2017,
                        SourceUrl = null,
                        IsHiddenSourceUrl = true,
                        IsHidden = false,
                        ReferenceUrl = null,
                        ImageFilePath = "/images/project/remoteattend.png"
                    },
                    Skills = new List<SkillEntity>
                    {
                        skills.SingleOrDefault(x => x.Name == Skill.Html.ToString()),
                        skills.SingleOrDefault(x => x.Name == Skill.Css.ToString()),
                        skills.SingleOrDefault(x => x.Name == Skill.Javascript.ToString()),
                        skills.SingleOrDefault(x => x.Name == Skill.Mysql.ToString()),
                        skills.SingleOrDefault(x => x.Name == Skill.Php.ToString()),
                        skills.SingleOrDefault(x => x.Name == Skill.Android.ToString()),
                    }
                },
                new ProjectSkillMatcher
                {
                    Project = new ProjectEntity
                    {
                        ProjectId = projectIndex++,
                        Name = "카풀 안드로이드 어플리케이션",
                        Description = "" +
                            "대학 과제로 제작했던 카풀 컨셉의 안드로이드 어플리케이션입니다.\n\n" +
                            "안드로이드 웹뷰를 이용한 하이브리드 방식으로 제작하였으며 회원가입시 운전자/동승자를 선택하면 조건에 맞는 상대방을 매칭해주는 시스템을 가지고 있습니다.\n\n" +
                            "현재 소스 코드가 분실되어 일부 자료만 존재합니다.",
                        ProjectType = ProjectType.Private,
                        CreateYear = 2017,
                        SourceUrl = null,
                        IsHiddenSourceUrl = true,
                        IsHidden = false,
                        ReferenceUrl = null,
                    },
                    Skills = new List<SkillEntity>
                    {
                        skills.SingleOrDefault(x => x.Name == Skill.Android.ToString()),
                        skills.SingleOrDefault(x => x.Name == Skill.AndroidWebView.ToString()),
                        skills.SingleOrDefault(x => x.Name == Skill.Jsp.ToString()),
                        skills.SingleOrDefault(x => x.Name == Skill.Mysql.ToString()),
                        skills.SingleOrDefault(x => x.Name == Skill.OpenAPI.ToString()),
                    }
                },
                new ProjectSkillMatcher
                {
                    Project = new ProjectEntity
                    {
                        ProjectId = projectIndex++,
                        Name = "각종 오토핫키로 제작한 프로그램",
                        Description = "" +
                            "고등학생때 게임 자동화를 목적으로 배운 스크립트 언어로 각종 편의 기능, 반복 업무 등 여러 분야에 대한 프로그램을 제작했습니다.\n\n" +
                            "현재 소스 코드가 분실되어 일부 자료만 존재합니다.",
                        ProjectType = ProjectType.Private | ProjectType.Deprecated,
                        CreateYear = 2010,
                        SourceUrl = null,
                        IsHiddenSourceUrl = true,
                        IsHidden = false,
                        ReferenceUrl = null,
                    },
                    Skills = new List<SkillEntity>
                    {
                        skills.SingleOrDefault(x => x.Name == Skill.AutoHotkey.ToString()),
                        skills.SingleOrDefault(x => x.Name == Skill.AutoHotkeyGUI.ToString()),
                    }
                },
                new ProjectSkillMatcher
                {
                    Project = new ProjectEntity
                    {
                        ProjectId = projectIndex++,
                        Name = "온라인 보드 게임 인식 프로그램",
                        Description = "" +
                            "온라인 보드 게임의 화면을 무작위로 촬영한 사진에서 게임 영역을 인식하여 데이터로 저장하는 프로그램입니다.",
                        ProjectType = ProjectType.Private,
                        CreateYear = 2020,
                        SourceUrl = "https://github.com/psg107/BaccaratHelper",
                        IsHiddenSourceUrl = true,
                        IsHidden = false,
                        ReferenceUrl = null,
                        ImageFilePath = "/images/project/bhd.png"
                    },
                    Skills = new List<SkillEntity>
                    {
                        skills.SingleOrDefault(x => x.Name == Skill.CSharp.ToString()),
                        skills.SingleOrDefault(x => x.Name == Skill.Dll.ToString()),
                        skills.SingleOrDefault(x => x.Name == Skill.OpenCV.ToString()),
                        skills.SingleOrDefault(x => x.Name == Skill.Regex.ToString()),
                    }
                },
                new ProjectSkillMatcher
                {
                    Project = new ProjectEntity
                    {
                        ProjectId = projectIndex++,
                        Name = "온라인 보드 게임 도우미 프로그램",
                        Description = "" +
                            "'온라인 보드 게임 인식 프로그램'으로 저장한 데이터를 가공하여 각종 정보를 출력하는 프로그램입니다.",
                        ProjectType = ProjectType.Private,
                        CreateYear = 2020,
                        SourceUrl = "https://github.com/psg107/BaccaratHelper",
                        IsHiddenSourceUrl = true,
                        IsHidden = false,
                        ReferenceUrl = null,
                        ImageFilePath = "/images/project/bh.png"
                    },
                    Skills = new List<SkillEntity>
                    {
                        skills.SingleOrDefault(x => x.Name == Skill.CSharp.ToString()),
                        skills.SingleOrDefault(x => x.Name == Skill.WPF.ToString()),
                        skills.SingleOrDefault(x => x.Name == Skill.Dll.ToString()),
                        skills.SingleOrDefault(x => x.Name == Skill.Regex.ToString()),
                        skills.SingleOrDefault(x => x.Name == Skill.RestAPI.ToString()),
                    }
                },
                new ProjectSkillMatcher
                {
                    Project = new ProjectEntity
                    {
                        ProjectId = projectIndex++,
                        Name = "온라인 보드 게임 도우미 인증 서버",
                        Description = "" +
                            "온라인 보드 게임 도우미 프로그램이 허용된 사용자만 사용할 수 있도록 하기 위해 제작한 인증 서버입니다.\n\n" +
                            "사용자 인증 허용, 사용자 차단 관리, 로그인 히스토리 등 기능이 포함되어 있습니다.",
                        ProjectType = ProjectType.Private,
                        CreateYear = 2020,
                        SourceUrl = "https://github.com/psg107/BaccaratHelper",
                        IsHiddenSourceUrl = true,
                        IsHidden = false,
                        ReferenceUrl = null,
                        ImageFilePath = "/images/project/bc.png"
                    },
                    Skills = new List<SkillEntity>
                    {
                        skills.SingleOrDefault(x => x.Name == Skill.CSharp.ToString()),
                        skills.SingleOrDefault(x => x.Name == Skill.AspDotNet.ToString()),
                        skills.SingleOrDefault(x => x.Name == Skill.AspDotNetWebAPI.ToString()),
                        skills.SingleOrDefault(x => x.Name == Skill.RestAPI.ToString()),
                        skills.SingleOrDefault(x => x.Name == Skill.EntityFramework.ToString()),
                        skills.SingleOrDefault(x => x.Name == Skill.JWT.ToString()),
                        skills.SingleOrDefault(x => x.Name == Skill.CentOS.ToString()),
                        skills.SingleOrDefault(x => x.Name == Skill.Mysql.ToString()),
                        skills.SingleOrDefault(x => x.Name == Skill.NaverCloudPlatform.ToString()),
                    }
                },
                new ProjectSkillMatcher
                {
                    Project = new ProjectEntity
                    {
                        ProjectId = projectIndex++,
                        Name = "온라인 보드 게임 도우미 관리자 프로그램",
                        Description = "" +
                            "온라인 보드 게임 도우미 프로그램이 허용된 사용자만 사용할 수 있도록 하기 위해 제작한 관리자 프로그램입니다.\n\n" +
                            "사용자 인증 허용, 사용자 차단 관리, 로그인 히스토리 등 기능이 포함되어 있습니다.",
                        ProjectType = ProjectType.Private,
                        CreateYear = 2020,
                        SourceUrl = "https://github.com/psg107/BaccaratHelper",
                        IsHiddenSourceUrl = true,
                        IsHidden = false,
                        ReferenceUrl = null,
                        ImageFilePath = "/images/project/bm.png"
                    },
                    Skills = new List<SkillEntity>
                    {
                        skills.SingleOrDefault(x => x.Name == Skill.CSharp.ToString()),
                        skills.SingleOrDefault(x => x.Name == Skill.WPF.ToString()),
                        skills.SingleOrDefault(x => x.Name == Skill.JWT.ToString()),
                        skills.SingleOrDefault(x => x.Name == Skill.AspDotNetWebAPI.ToString())
                    }
                },
                new ProjectSkillMatcher
                {
                    Project = new ProjectEntity
                    {
                        ProjectId = projectIndex++,
                        Name = "MS문서 언어전환 버튼 고정 크롬 확장프로그램",
                        Description = "MS문서를 볼 때 스크롤을 아래로 내리더라도 '영어로보기' 버튼이 우측 하단에 고정되는 크롬 확장 프로그램입니다.",
                        ProjectType = ProjectType.Private,
                        CreateYear = 2020,
                        SourceUrl = "https://github.com/psg107/StickyMSDocumentLanguageSwitch",
                        IsHiddenSourceUrl = true,
                        IsHidden = false,
                        ReferenceUrl = "https://chrome.google.com/webstore/detail/sticky-ms-document-langua/ginmikdcecllccphippnbjjlinaeecma?utm_source=chrome-ntp-icon",
                        ImageFilePath = "/images/project/sm.jpg"
                    },
                    Skills = new List<SkillEntity>
                    {
                        skills.SingleOrDefault(x => x.Name == Skill.Html.ToString()),
                        skills.SingleOrDefault(x => x.Name == Skill.Css.ToString()),
                        skills.SingleOrDefault(x => x.Name == Skill.Javascript.ToString()),
                    }
                },
                new ProjectSkillMatcher
                {
                    Project = new ProjectEntity
                    {
                        ProjectId = projectIndex++,
                        Name = "넓게보는 Stackoverflow 크롬 확장프로그램",
                        Description = "" +
                            "Stackoverflow를 볼 때 좌우 불필요한 공간 제거 및 소스 코드 스크롤 제거 기능이 포함된 크롬 확장프로그램입니다.\n\n" +
                            "스토어에 올리기 전 검색을 해보니 이미 비슷한 기능의 확장프로그램이 올라와 있어서 깃허브에만 올려놓았습니다.",
                        ProjectType = ProjectType.Private,
                        CreateYear = 2020,
                        SourceUrl = "https://github.com/psg107/WideStackoverflow",
                        IsHiddenSourceUrl = true,
                        IsHidden = false,
                        ReferenceUrl = null,
                        ImageFilePath = "/images/project/ws.png"
                    },
                    Skills = new List<SkillEntity>
                    {
                        skills.SingleOrDefault(x => x.Name == Skill.Html.ToString()),
                        skills.SingleOrDefault(x => x.Name == Skill.Css.ToString()),
                        skills.SingleOrDefault(x => x.Name == Skill.Javascript.ToString()),
                    }
                },
                new ProjectSkillMatcher
                {
                    Project = new ProjectEntity
                    {
                        ProjectId = projectIndex++,
                        Name = "모바일 끝말잇기 미니 게임 도우미",
                        Description = "" +
                            "끝말잇기 미니게임을 도와주는 프로그램입니다.\n\n" +
                            "안드로이드 에뮬레이터 화면에서 상대방이 입력한 단어의 끝글자를 인식하여 해당 글자로 시작하는 단어를 자동으로 추천합니다.",
                        ProjectType = ProjectType.Private,
                        CreateYear = 2020,
                        SourceUrl = "https://github.com/psg107/PriconeWordChainingHelper",
                        IsHiddenSourceUrl = true,
                        IsHidden = false,
                        ReferenceUrl = null,
                        ImageFilePath = "/images/project/pw.png"
                    },
                    Skills = new List<SkillEntity>
                    {
                        skills.SingleOrDefault(x => x.Name == Skill.CSharp.ToString()),
                        skills.SingleOrDefault(x => x.Name == Skill.WPF.ToString()),
                        skills.SingleOrDefault(x => x.Name == Skill.Regex.ToString()),
                        skills.SingleOrDefault(x => x.Name == Skill.OpenCV.ToString()),
                        skills.SingleOrDefault(x => x.Name == Skill.Tesseract.ToString()),
                    }
                },
                new ProjectSkillMatcher
                {
                    Project = new ProjectEntity
                    {
                        ProjectId = projectIndex++,
                        Name = "파일 인코딩 변환기",
                        Description = "" +
                            "특정 폴더 하위 파일의 인코딩을 일괄 변환하는 프로그램입니다..\n\n" +
                            "현재 UTF-8, EUC-KR 인코딩을 지원합니다.",
                        ProjectType = ProjectType.Private,
                        CreateYear = 2020,
                        SourceUrl = "https://github.com/psg107/EncodingChanger",
                        IsHiddenSourceUrl = true,
                        IsHidden = false,
                        ReferenceUrl = null,
                        ImageFilePath = "/images/project/ec.png"
                    },
                    Skills = new List<SkillEntity>
                    {
                        skills.SingleOrDefault(x => x.Name == Skill.CSharp.ToString()),
                        skills.SingleOrDefault(x => x.Name == Skill.WPF.ToString()),
                    }
                },
                new ProjectSkillMatcher
                {
                    Project = new ProjectEntity
                    {
                        ProjectId = projectIndex++,
                        Name = "웃긴대학 자동 어시스트 프로그램",
                        Description = "" +
                            "인터넷 커뮤니티 웃긴대학 대기자료에 있는 게시글을 자동으로 추천하는 프로그램입니다.\n\n" +
                            "추천 및 반대 가중치를 계산하여 어시스트가 가능한 글을 자동으로 추천합니다.",
                        ProjectType = ProjectType.Private,
                        CreateYear = 2021,
                        SourceUrl = "https://github.com/psg107/HumorUnivAutoAssist",
                        IsHiddenSourceUrl = false,
                        IsHidden = false,
                        ReferenceUrl = null,
                        ImageFilePath = "/images/project/hu.png"
                    },
                    Skills = new List<SkillEntity>
                    {
                        skills.SingleOrDefault(x => x.Name == Skill.CSharp.ToString()),
                        skills.SingleOrDefault(x => x.Name == Skill.Console.ToString()),
                        skills.SingleOrDefault(x => x.Name == Skill.Regex.ToString()),
                        skills.SingleOrDefault(x => x.Name == Skill.XPath.ToString())
                    }
                },
                new ProjectSkillMatcher
                {
                    Project = new ProjectEntity
                    {
                        ProjectId = projectIndex++,
                        Name = "음악 추천 블로그",
                        Description = "" +
                            "음악 추천 컨셉의 블로그 형태의 웹사이트입니다.\n\n" +
                            "닷넷 코어에 적응하기 위한 연습용 프로젝트로 음악 정보를 직접 입력하거나 유튜브 링크를 입력하여 음악을 등록할 수 있으며 사용자 권한에 따른 처리를 지원합니다.",
                        ProjectType = ProjectType.Private | ProjectType.Incomplete,
                        CreateYear = 2021,
                        SourceUrl = "https://github.com/psg107/SimpleBlog",
                        IsHiddenSourceUrl = false,
                        IsHidden = false,
                        ReferenceUrl = null,
                    },
                    Skills = new List<SkillEntity>
                    {
                        skills.SingleOrDefault(x => x.Name == Skill.CSharp.ToString()),
                        skills.SingleOrDefault(x => x.Name == Skill.AspDotNetMVC.ToString()),
                        skills.SingleOrDefault(x => x.Name == Skill.AspDotNetWebAPI.ToString()),
                        skills.SingleOrDefault(x => x.Name == Skill.EntityFramework.ToString()),
                        skills.SingleOrDefault(x => x.Name == Skill.Razor.ToString()),
                        skills.SingleOrDefault(x => x.Name == Skill.Html.ToString()),
                        skills.SingleOrDefault(x => x.Name == Skill.Css.ToString()),
                        skills.SingleOrDefault(x => x.Name == Skill.Javascript.ToString()),
                        skills.SingleOrDefault(x => x.Name == Skill.JQuery.ToString()),
                        skills.SingleOrDefault(x => x.Name == Skill.Bootstrap.ToString()),
                    }
                },
                new ProjectSkillMatcher
                {
                    Project = new ProjectEntity
                    {
                        ProjectId = projectIndex++,
                        Name = "스위치봇 제어 어플리케이션",
                        Description = "" +
                            "스위치봇이라는 IOT 기기를 제어하는 모바일 어플리케이션입니다. \n\n" +
                            "위젯을 통해 스위치봇을 제어하기 위해서는 스위치봇허브라는 제품을 구매해야 하는데 이 제품을 구매하지 않고 위젯을 통해 스위치봇을 제어할 수 있습니다.\n\n" +
                            "현재 안드로이드만 지원합니다.",
                        ProjectType = ProjectType.Private | ProjectType.Incomplete,
                        CreateYear = 2021,
                        SourceUrl = "https://github.com/psg107/XamarinSwitchBot",
                        IsHiddenSourceUrl = false,
                        IsHidden = false,
                        ReferenceUrl = null,
                        ImageFilePath = "/images/project/swb.jpg"
                    },
                    Skills = new List<SkillEntity>
                    {
                        skills.SingleOrDefault(x => x.Name == Skill.CSharp.ToString()),
                        skills.SingleOrDefault(x => x.Name == Skill.Xamarin.ToString()),
                        skills.SingleOrDefault(x => x.Name == Skill.BLE.ToString()),
                        skills.SingleOrDefault(x => x.Name == Skill.Android.ToString()),
                        skills.SingleOrDefault(x => x.Name == Skill.IOS.ToString()),
                    }
                },
            };

            var projects = projectSkillMatchers.Select(x => x.Project).ToList();
            var projectSkills = projectSkillMatchers.SelectMany(x => x.Skills.Select(y => new ProjectSkillEntity 
            {
                ProjectId = x.Project.ProjectId,
                SkillId = y.SkillId
            })).ToList();

            return (skills, projects, projectSkills);
        }
    }
}
