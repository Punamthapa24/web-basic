let titleH1 = document.getElementById("title");
titleH1.style.color = "green";
titleH1.style.fontFamily = "Helvetica";

function printNumbers(){
   let upto = document.getElementById("UpperRange").value
   titleH1.innerText = "Numbers from 1 to" + upto;
   let numbersDiv = document.getElementById("numbers");
let numbersHtml = "";
for (let i = 1; i <= upto; i++) {
    numbersHtml = numbersHtml + "<h2  class='badge text-bg-danger'>"+i+"</h2>";
}
numbersDiv.innerHTML = numbersHtml;
}


// let titleH1 = document.getElementById("title");
// titleH1.style.color = "green";
// titleH1.style.fontFamily = "Helvetica";

// function printNumbers(){
//    let upto = document.getElementById("UpperRange").value
//    titleH1.innerText = "Numbers from 1 to 500" ;
//    let numbersDiv = document.getElementById("numbers");
// let numbersHtml = "";
// for (let i = 1; i <= 500; i++) {
//     numbersHtml = numbersHtml + "<h2  class='badge text-bg-danger'>"+i+"</h2>";
// }
// numbersDiv.innerHTML = numbersHtml;

