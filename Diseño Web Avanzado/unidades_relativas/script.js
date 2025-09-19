const getScrollWidth = ()=> innerWidth - document.documentElement.clientWidth
console.log(getScrollWidth())
document.documentElement.style.setProperty('--scroll-bar',getScrollWidth())