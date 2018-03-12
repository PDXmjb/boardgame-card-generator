$(document).ready(function () {
    var $this;
    $(".card-label").click(function(){
        $this = $(this);
        var $labelInput = $("#labelInput");
        $labelInput.val($this.text());
        var $cssInput = $("#cssInput");
        $cssInput.val($this.attr("style"));
        console.log($this.attr("style"));
        var $backgroundInput = $("#backgroundInput");
        $backgroundInput.val($this.css("background"))
    });

    $("#preview-button").click(function () {
        if ($this)
        {
            $this.text($("#labelInput").val());
            $this.attr("style", $("#cssInput").val());
            $this.css("background", $("#backgroundInput").val());
        }
    });
});