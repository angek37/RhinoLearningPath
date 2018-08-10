$(function () {
    $("#submitButton").on("click", getShowName);

    function getShowName(event) {
        event.preventDefault();
        var searchValue = $("#showInput")[0].value;
        if(searchValue.length > 0){
            $.tvmaze.getShow(searchValue, function (results) {
                displayShowResults(results[0].show);
            });
        }
    }
});

function displayShowResults(results) {
    $('#tableBody').html('<td id="episodeName" data-episodeid="' + results.id + '">'
        + results.name + '</td>' + '<td>'
        + checkNetwork(results.network) + '</td>'
        + '<td>' + results.type + '</td>'
        + '<td><img class="image-border" src="'
        + results.image.medium + '"> </td>');
    $('#episodeInfo tr').remove();
    $('#episodeName').on("click", function (event) {
        getEpisodes(event.target.dataset.episodeid);
    });
}

function checkNetwork(networkName) {
    if(networkName != null){
        return networkName.name;
    }else{
        return "not Listed";
    }
}

function getEpisodes(episodeID) {
    $.tvmaze.getEpisode(episodeID, function (results) {
        for(var i = 0; i < results.length; i++){
            $("#episodeInfo").append("<tr><td>"
                + results[i].airdate + "</td><td>"
                + results[i].name + "</td><td>"
                + results[i].number + "</td><td>"
                + results[i].season + "</td><td>"
                + results[i].runtime + "</td><td>"
                + results[i].summary + "</td></tr>");
        }
    });
}