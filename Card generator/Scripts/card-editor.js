$(document).ready(function () {
    $(".card-label").click(function(){
        var $this = $(this);
        var $labelInput = $("#labelInput");
        console.log($this.text());
        $labelInput.val($this.text());

    });
});