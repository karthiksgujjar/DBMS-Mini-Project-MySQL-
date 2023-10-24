const slider = document.getElementById('screenshots-slider');
const images = slider.firstElementChild.children;
const imageBubbles = slider.lastElementChild.children;
let imageNumber = 0;

    fadeOut(imageNumber);

function fadeOut(imageNumber) {
    imageBubbles[imageNumber].innerHTML = '&bigodot;';
    setTimeout(() => {
        images[imageNumber].setAttribute("hidden", true);
        imageBubbles[imageNumber].innerHTML = '&bullet;';
        if (imageNumber != 4)
            fadeIn(imageNumber + 1);
        else
            fadeIn(0);
    }, 2000);

}

function fadeIn(imageNumber) {
    images[imageNumber].removeAttribute("hidden");
    images[imageNumber].style = "animation: fadeIn 1s ease-in-out;";
    imageBubbles[imageNumber].innerHTML = '&bigodot;';
    setTimeout(() => {
        fadeOut(imageNumber);
    },2000)
}

function openMailTo(){
    const sendMailLink = document.createElement('a');
    sendMailLink.href = `mailto:someone@gmail.com?&subject=Comment on SLS from ${document.getElementById('name').value} &body=${document.getElementById('comment').value}`;
    sendMailLink.click();
}