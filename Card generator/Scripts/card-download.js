$(document).ready(function () {
    //var elements = $(".card").each(function () {
    //    var $this = $(this);

    //    var element = $(this).get(0);
    //    html2canvas(element).then(function (canvas) {
    //        var imageData = canvas.toDataURL("image/png");
    //        var newData = imageData.replace(/^data:image\/png/, "data:application/octet-stream");
    //        var $downloadLink = $("#btn-Convert-Html2Image");
    //        $this.css("display", "inline-block");
    //        $downloadLink.attr("download", $this.find(".top.centerColumn").text() + ".png").attr("href", newData);
    //        //$this.css("display", "none");
    //        // Performs the download automatically.
    //        //$downloadLink[0].click();
    //    });
    //});

    $("#cardSelector").change(function () {
        $(".card.border-div").addClass("hidden-card");
        if ($(this).val() == "all")
        {
            $(".card.border-div").removeClass("hidden-card");
            $("#editor").css("display", "none");
            $("#card-chooser-div").removeClass("col-md-5").addClass("col-md-10");
        }
        else
        {
            $("#" + $(this).val()).removeClass("hidden-card");
            $("#editor").css("display", "inline-block");
            $("#card-chooser-div").removeClass("col-md-10").addClass("col-md-5");
        }
    });

    
    
});    
