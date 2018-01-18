namespace Card_generator.Models
{
    public class CardLabel
    {
        public string BackgroundImage { get; set; }
        public string BackgroundColor { get; set; }
        public string AdditionalCSS { get; set; }
        public string Label { get; set; }

        public CardLabel(string label, string backgroundImage, string backgroundColor, string additionalCSS)
        {
            Label = label;
            BackgroundImage = backgroundImage;
            BackgroundColor = backgroundColor;
            AdditionalCSS = additionalCSS;
        }
    }
}