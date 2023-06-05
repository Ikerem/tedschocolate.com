var openButton = document.getElementById('open-btn');

openButton.addEventListener('click', function () {
    setTimeout(function () {
        window.open('popup.html');
    }, 2000); // 2000 milisaniye (2 saniye) sonra sayfayý aç
});
