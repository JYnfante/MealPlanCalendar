// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

load();

let calendarEl = document.getElementById('calendar');

let calendar = new FullCalendar.Calendar(calendarEl, {
    initialView: 'dayGridMonth',
    navLinks: true,
    editable: true,
    selectable: true,
    handleWindowResize: true,
    headerToolbar: {
        left: 'prev,next today',
        center: 'title',
        right: 'dayGridMonth,listWeek'
    },
    events: eventsArr,
    eventClick: function (info) {
        if (confirm('Are you sure you want to delete: ' + info.event.title)) {
            calendar.getEventById(info.event.id).remove();
            removeMenuItem(info.event.id);
            save();
            load();
        }
    },
    eventColor: 'blue',
    /*
    eventContent: function (arg) {
        let arrayOfDomNodes = []
        // title event
        let titleEvent = document.createElement('div')
        if (arg.event._def.title) {
            titleEvent.innerHTML = arg.event._def.title
            titleEvent.classList = "fc-event-title fc-sticky"
        }

        // image event
        
        let imgEventWrap = document.createElement('div')
        if (arg.event.extendedProps.image_url) {
            let imgEvent = '<img src="' + arg.event.extendedProps.image_url + '"width = "16" height = "16">'
            imgEventWrap.classList = "fc-event-img"
            imgEventWrap.innerHTML = imgEvent;
        }

        arrayOfDomNodes = [titleEvent, imgEventWrap]

        return { domNodes: arrayOfDomNodes }
    },*/
})
calendar.render();

function addMenuItem() {
    var name = document.getElementsByName("name")[0].value;
    var date = document.getElementsByName("date")[0].value;
    var time = document.getElementsByName("time")[0].value;

    var imageUrl = "/images/" + name + ".jpg";

    let event = {
        id: eventsArr.length,
        title: name,
        start: date + " " + time,
        image_url: imageUrl
    }

    eventsArr.push(event);
    save();


    let calendarEl = document.getElementById('calendar');

    let calendar = new FullCalendar.Calendar(calendarEl, {


        initialView: 'dayGridMonth',
        navLinks: true,
        editable: true,
        selectable: true,
        handleWindowResize: true,
        headerToolbar: {
            left: 'prev,next today',
            center: 'title',
            right: 'dayGridMonth,listWeek'
        },
        /*
        eventDidMount: function (info) {
            var tooltip = new Tooltip(info.el, {
                title: info.event.extendedProps.image_url,
                placement: 'top',
                trigger: 'hover',
                container: 'body'
            });
        },*/
        events: eventsArr,
        eventClick: function (info) {
            if (confirm('Are you sure you want to delete: ' + info.event.title))
            {
                calendar.getEventById(info.event.id).remove();
                removeMenuItem(info.event.id);
                save();
                load();
            }
        },
        eventColor: 'blue',
    })    
    calendar.render();
}

function save() {
    let stringified = JSON.stringify(eventsArr);
    localStorage.setItem("menuList", stringified);
}

function load() {
    let retrieved = localStorage.getItem("menuList");
    eventsArr = JSON.parse(retrieved);
    if (eventsArr == null)
        eventsArr = [];
}

function removeMenuItem (menuItemId) {

    for (let i = 0; i < eventsArr.length; i++) {
        if (eventsArr[i].id == menuItemId)
            eventsArr.splice(i, 1);
    }
    save();
}
