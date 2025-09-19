const imgSrc = document.querySelector(".poster").children[0].src
const blurBg = document.querySelector(".blur")
blurBg.style.backgroundImage = `url(${imgSrc})`