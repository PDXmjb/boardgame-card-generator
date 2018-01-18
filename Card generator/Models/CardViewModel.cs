﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Card_generator.Models
{
    /// <summary>
    /// Represents the supported structure of a playing card.
    /// </summary>
    public class CardViewModel
    {
        /// <summary>
        /// Used primarily for determining background of the card.
        /// </summary>
        public string BackgroundImage { get; set; }

        /// <summary>
        /// Color used if no image is supplied. If neither are supplied, will default to white.
        /// </summary>
        public string BackgroundColor { get; set; }

        /// <summary>
        /// Labels for rendering text on the card. Not rendered if unavailable.
        /// </summary>
        public CardLabel TopLeftLabel { get; set; }
        public CardLabel TopCenterLabel { get; set; }        
        public CardLabel TopRightLabel { get; set; }
        public CardLabel CenterLeftLabel { get; set; }
        public CardLabel CenterLabel { get; set; }
        public CardLabel CenterRightLabel { get; set; }
        public CardLabel BottomLeftLabel { get; set; }
        public CardLabel BottomCenterLabel { get; set; }
        public CardLabel BottomRightLabel { get; set; }

        public CardViewModel(string backgroundImage, string backgroundColor, CardLabel topLeftLabel, CardLabel topCenterLabel, 
                             CardLabel topRightLabel, CardLabel centerLeftLabel, CardLabel centerLabel, CardLabel centerRightLabel, 
                             CardLabel bottomLeftLabel, CardLabel bottomCenterLabel, CardLabel bottomRightLabel)
        {
            BackgroundImage = backgroundImage;
            BackgroundColor = backgroundColor;
            TopLeftLabel = topLeftLabel;
            TopCenterLabel = topCenterLabel;
            TopRightLabel = topRightLabel;
            CenterLeftLabel = centerLeftLabel;
            CenterLabel = centerLabel;
            CenterRightLabel = centerRightLabel;
            BottomLeftLabel = bottomLeftLabel;
            BottomCenterLabel = bottomCenterLabel;
            BottomRightLabel = bottomRightLabel;
        }
    }
}