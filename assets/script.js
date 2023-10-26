const slider = document.getElementById('screenshots-slider');
const images = slider.firstElementChild.children;
const imageBubbles = slider.lastElementChild.children;
let imageNumber = 0;

setInterval(() =>{
    images[imageNumber].setAttribute("hidden", true);
    imageBubbles[imageNumber].innerHTML = '&bullet;';
    showImage((imageNumber != 4)?++imageNumber:imageNumber=0);
    // if (imageNumber != 4){
    //     showImage(++imageNumber); 
    // }
    // else
    //     showImage(imageNumber = 0); // It is needed to assign imageNumber with 0 here, because the imageNumber which is global doesn't get updated otherwise like if we send showImage(0) and it'll break the flow of transistioning of the image.
},3000);

function showImage(imageNumber){
    images[imageNumber].removeAttribute("hidden");
        imageBubbles[imageNumber].innerHTML = '&bigodot;';
        images[imageNumber].style = "animation: fadeIn 1s ease-in-out;";
}

function openMailTo(){
    const sendMailLink = document.createElement('a');
    sendMailLink.href = `mailto:gfgctumkur.pgms.bca6.2023@gmail.com?&subject=Comment on SLS from ${document.getElementById('name').value} &body=${document.getElementById('comment').value}`;
    sendMailLink.click();
}