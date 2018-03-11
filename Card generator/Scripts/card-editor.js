$(document).ready(function () {
    var $this;
    $(".card-label").click(function(){
        $this = $(this);
        var $labelInput = $("#labelInput");
        $labelInput.val($this.text());
        //var $cssInput = $("#cssInput");
        //$cssInput.val($this.prop("style"));
        console.log($this.prop("style"));
    });

    $("#preview-button").click(function () {
        if ($this)
        {
            $this.text($("#labelInput").val());
        }
    });
});