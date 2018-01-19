$(document).ready(function () {
    var elements = $(".card").each(function () {
        var $this = $(this);
        var element = $(this).get(0);
        html2canvas(element).then(function (canvas) {
            var imageData = canvas.toDataURL("image/png");
            var newData = imageData.replace(/^data:image\/png/, "data:application/octet-stream");
            var $downloadLink = $("#btn-Convert-Html2Image");
            $downloadLink.attr("download", $this.find(".top.centerColumn").text() + ".png").attr("href", newData);

            // Performs the download automatically.
            $downloadLink[0].click();
        });
    })
    
});    
