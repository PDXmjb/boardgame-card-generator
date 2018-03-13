$(document).ready(function () {
    var $this;
    $(".card-label").click(function(){
        $this = $(this);
        var $labelInput = $("#labelInput");
        $labelInput.val($this.text());
        var $cssInput = $("#cssInput");
        $cssInput.val($this.attr("style"));
        console.log($this.attr("style"));
        var $backgroundImageInput = $("#backgroundImageInput");
        $backgroundImageInput.val($this.css("background-image"))
        var $backgroundColorInput = $("#backgroundColorInput");
        $backgroundColorInput.val($this.css("background-color"))

    });

    $("#preview-button").click(function () {
        if ($this)
        {
            $this.text($("#labelInput").val());
            $this.attr("style", $("#cssInput").val());
            $this.css("background-image", $("#backgroundImageInput").val());
            $this.css("background-color", $("#backgroundColorInput").val());
        }
    });
});