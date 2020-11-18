/**
 * id로 스크롤
 * @param {any} id
 */
function blazorScrollToId(id) {
    const element = document.getElementById(id);
    if (element instanceof HTMLElement) {
        element.scrollIntoView();
    }
}

/**
 * ㅇㅇㅇ
 * @param {any} projectContainer
 */
function addScrollEvent(introContainer, skillContainer, projectContainer) {
    const offset = 5;  //뭔지 모를 offset
    let introScrollOffsetTop = introContainer.offsetTop + introContainer.clientHeight;
    let skillScrollOffsetTop = skillContainer.offsetTop + skillContainer.clientHeight;
    let projectScrollOffsetTop = projectContainer.offsetTop + projectContainer.clientHeight;
    
    let updateScrollbar = () => {
        let scrollY = window.scrollY;

        if (introScrollOffsetTop >= scrollY + offset) {
            DotNet.invokeMethodAsync('Portfolio', 'ScrollCallback', '소개')
            return
        }
        if (skillScrollOffsetTop >= scrollY + offset) {
            DotNet.invokeMethodAsync('Portfolio', 'ScrollCallback', '스킬')
            return
        }
        if (projectScrollOffsetTop >= scrollY + offset) {
            DotNet.invokeMethodAsync('Portfolio', 'ScrollCallback', '프로젝트')
            return
        }
    };

    window.addEventListener('scroll', (e) => updateScrollbar());
    updateScrollbar();
}