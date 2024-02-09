// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
document.addEventListener('DOMContentLoaded', function () {
    const filterList = document.getElementById('FilterList');
    const filterVacancy = document.getElementById('VacancyFilter');
    const filterRoom = document.getElementById('RoomTypeFilter');
    const filterBalcony = document.getElementById('BalconyFilter');
    const filterBtn = document.getElementById('FilterBtn');

    filterList.addEventListener('change', function () {
        switch (filterList.value)
        {
            case 'IsVacant':
                filterVacancy.style.display = 'block';
                filterRoom.style.display = 'none';
                filterBalcony.style.display = 'none';
                filterBtn.disabled = false;
                break;
            case 'RoomType':
                filterRoom.style.display = 'block';
                filterVacancy.style.display = 'none';
                filterBalcony.style.display = 'none';
                filterBtn.disabled = false;
                break;
            case 'HasBalcony':
                filterBalcony.style.display = 'block';
                filterVacancy.style.display = 'none';
                filterRoom.style.display = 'none';
                filterBtn.disabled = false;
                break;
            default:
                filterVacancy.style.display = 'none';
                filterRoom.style.display = 'none';
                filterBalcony.style.display = 'none';
                filterBtn.disabled = true;
        }
    });
});