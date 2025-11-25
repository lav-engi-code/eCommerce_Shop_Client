window.ShowDialog = function () {
    const dialog = document.getElementById('my-dialog');
    if (dialog) {
        dialog.showModal(); // built-in dialog API
    } else {
        console.error("Dialog element not found");
    }
};