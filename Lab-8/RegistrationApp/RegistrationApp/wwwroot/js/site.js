// Basic form validation script
document.addEventListener('DOMContentLoaded', function () {
    const form = document.querySelector('form');
    if (form) {
        form.addEventListener('submit', function (event) {
            const inputs = form.querySelectorAll('input');
            let isValid = true;
            inputs.forEach(input => {
                if (!input.value.trim()) {
                    isValid = false;
                    alert(`${input.name} is required.`);
                    event.preventDefault();
                }
            });
        });
    }
});
