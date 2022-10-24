$(document).ready(function () {
    var flexItems = document.getElementsByClassName("flex-item");

    for (var i = 0; i < flexItems.length; i++) {
        const flexItemStatus = flexItems.item(i).dataset.status;

        if (!flexItemStatus) {
            return;
        }

        if (flexItemStatus == 'Skip') {
            flexItems.item(i).className += ' transparent-colour';
        }
        else if (flexItemStatus == 'Available') {
            flexItems.item(i).className += ' green-colour is-item';
        }
        else if (flexItemStatus == 'Pending') {
            flexItems.item(i).className += ' gray-colour is-item';
        }
        else if (flexItemStatus == 'Sold') {
            flexItems.item(i).className += ' red-colour is-item';
        }
    }
});

document.body.onclick = function (e) {
    e = e.target

    if (e.className && e.className.indexOf('green-colour') != -1) {
        alert(`You clicked ${e.dataset.name}`);
    }
}