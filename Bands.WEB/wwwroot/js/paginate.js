$(document).ready(
    function () {
        var pageNumber = 0;
        var win = $(window);

        var allDataLoaded = false;

        win.scroll(function () {
            if (allDataLoaded)
                return;
            if ($(document).height() - win.height() == win.scrollTop()) {
                pageNumber += 1;

                $('#loading').show();

                var query = $("#search-query").val();

                var url = 'MusiciansPage?pageNumber=' + pageNumber;

                if (query !== '')
                    url += "&name=" + query;

                $.ajax({
                    url: url,
                    dataType: 'html',
                    success: function (html) {
                        if (parseInt($(html).filter("#musicians-count").val()) < 5)
                            allDataLoaded = true;
                        $('#musician-list-content').append(html);
                        $('#loading').hide();
                    }
                });
            }
        });
    });