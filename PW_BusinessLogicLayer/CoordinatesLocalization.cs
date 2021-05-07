using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using DataClasses.Domain.Collections;
using DataClasses.Domain.Picture;
using PW_BusinessLogicLayer.Interfaces;

namespace PW_BusinessLogicLayer
{
    public class CoordinatesLocalization : ICoordinatesLocalization
    {
        public LocationOnBody Location { get; set; }
        public Collection Collections { get; set; }

        public CoordinatesLocalization(LocationOnBody locationOnBody, Collection collection)
        {
            Collections = collection;
            Location = locationOnBody;
        }

        #region FemaleFront

        public bool LocalizePointFemaleFront(bool PointClicked, int X, int Y)
        {
            if (Y < 203) //alt over hoften
            {
                if (X > 86 && X < 124 && Y > 0 && Y < 19)
                {
                    Debug.WriteLine("Pande");
                    Debug.WriteLine("Koordinater: {0}, {1}", X, Y);
                    Location.BodyParts = LocationOnBody.BodyPart.Pande;

                    PointClicked = true;
                }
                else if ((X > 88 && X < 98 && Y > 35 && Y < 55) || (X > 110 && X < 124 && Y > 35 && Y < 55))
                {
                    Debug.WriteLine("Kind");
                    Debug.WriteLine("Koordinater: {0}, {1}", X, Y);
                    Location.BodyParts = LocationOnBody.BodyPart.Kind;

                    PointClicked = true;
                }
                else if (X > 98 && X < 110 && Y > 27 && Y < 42)
                {
                    Debug.WriteLine("Næse");
                    Debug.WriteLine("Koordinater: {0}, {1}", X, Y);
                    Location.BodyParts = LocationOnBody.BodyPart.Næse;

                    PointClicked = true;
                }
                else if (X > 98 && X < 110 && Y > 42 && Y < 51)
                {
                    Debug.WriteLine("Læber");
                    Debug.WriteLine("Koordinater: {0}, {1}", X, Y);
                    Location.BodyParts = LocationOnBody.BodyPart.Læber;

                    PointClicked = true;
                }
                else if (X > 92 && X < 120 && Y > 51 && Y < 60)
                {
                    Debug.WriteLine("Hage");
                    Debug.WriteLine("Koordinater: {0}, {1}", X, Y);
                    Location.BodyParts = LocationOnBody.BodyPart.Hage;

                    PointClicked = true;
                }
                else if ((X > 83 && X < 87 && Y > 30 && Y < 42) || (X > 125 && X < 130 && Y > 30 && Y < 42))
                {
                    Debug.WriteLine("Øre");
                    Debug.WriteLine("Koordinater: {0}, {1}", X, Y);
                    Location.BodyParts = LocationOnBody.BodyPart.Øre;

                    PointClicked = true;
                }
                else if (X > 92 && X < 120 && Y > 57 && Y < 75)
                {
                    Debug.WriteLine("Hals");
                    Debug.WriteLine("Koordinater: {0}, {1}", X, Y);
                    Location.BodyParts = LocationOnBody.BodyPart.Hals;

                    PointClicked = true;
                }
                else if ((X > 51 && X < 80 && Y > 80 && Y < 108) || (X > 131 && X < 160 && Y > 80 && Y < 108))
                {
                    Debug.WriteLine("Skulder");
                    Debug.WriteLine("Koordinater: {0}, {1}", X, Y);
                    Location.BodyParts = LocationOnBody.BodyPart.Skulder;

                    PointClicked = true;
                }
                else if (X > 67 && X < 143 && Y > 75 && Y < 138)
                {
                    Debug.WriteLine("Bryst");
                    Debug.WriteLine("Koordinater: {0}, {1}", X, Y);
                    Location.BodyParts = LocationOnBody.BodyPart.Bryst;

                    PointClicked = true;
                }
                else if (X > 66 && X < 145 && Y > 138 && Y < 203)
                {
                    Debug.WriteLine("Mave");
                    Debug.WriteLine("Koordinater: {0}, {1}", X, Y);
                    Location.BodyParts = LocationOnBody.BodyPart.Mave;

                    PointClicked = true;
                }
                else if ((X > 44 && X < 61 && Y > 108 && Y < 161) || (X > 143 && X < 168 && Y > 108 && Y < 161))
                {
                    Debug.WriteLine("Overarm");
                    Debug.WriteLine("Koordinater: {0}, {1}", X, Y);
                    Location.BodyParts = LocationOnBody.BodyPart.Overarm;

                    PointClicked = true;
                }
                else if ((X > 18 && X < 61 && Y > 161 && Y < 224) || (X > 152 && X < 192 && Y > 161 && Y < 224))
                {
                    Debug.WriteLine("Underarm");
                    Debug.WriteLine("Koordinater: {0}, {1}", X, Y);
                    Location.BodyParts = LocationOnBody.BodyPart.Underarm;

                    PointClicked = true;
                }
            }

            else //alt under hoften
            {
                if ((X > 13 && X < 33 && Y > 224 && Y < 253) || (X > 178 && X < 199 && Y > 224 && Y < 253))
                {
                    Debug.WriteLine("Håndflade");
                    Debug.WriteLine("Koordinater: {0}, {1}", X, Y);
                    Location.BodyParts = LocationOnBody.BodyPart.Håndflade;

                    PointClicked = true;
                }
                else if ((X > 0 && X < 13 && Y > 231 && Y < 252) || (X > 199 && X < 211 && Y > 231 && Y < 255))
                {
                    Debug.WriteLine("Tommelfinger");
                    Debug.WriteLine("Koordinater: {0}, {1}", X, Y);
                    Location.BodyParts = LocationOnBody.BodyPart.Tommelfinger;

                    PointClicked = true;
                }
                else if ((X > 9 && X < 28 && Y > 253 && Y < 274) || (X > 184 && X < 204 && Y > 253 && Y < 274))
                {
                    Debug.WriteLine("Finger");
                    Debug.WriteLine("Koordinater: {0}, {1}", X, Y);
                    Location.BodyParts = LocationOnBody.BodyPart.Finger;

                    PointClicked = true;
                }
                else if (X > 58 && X < 155 && Y > 203 && Y < 246)
                {
                    Debug.WriteLine("Underliv");
                    Debug.WriteLine("Koordinater: {0}, {1}", X, Y);
                    Location.BodyParts = LocationOnBody.BodyPart.Underliv;

                    PointClicked = true;
                }
                else if ((X > 57 && X < 105 && Y > 246 && Y < 317) || (X > 108 && X < 155 && Y > 246 && Y < 317))
                {
                    Debug.WriteLine("Lår");
                    Debug.WriteLine("Koordinater: {0}, {1}", X, Y);
                    Location.BodyParts = LocationOnBody.BodyPart.Lår;

                    PointClicked = true;
                }
                else if ((X > 73 && X < 103 && Y > 317 && Y < 352) || (X > 110 && X < 141 && Y > 317 && Y < 352))
                {
                    Debug.WriteLine("Knæ");
                    Debug.WriteLine("Koordinater: {0}, {1}", X, Y);
                    Location.BodyParts = LocationOnBody.BodyPart.Knæ;

                    PointClicked = true;
                }
                else if ((X > 70 && X < 101 && Y > 352 && Y < 438) || (X > 113 && X < 144 && Y > 352 && Y < 438))
                {
                    Debug.WriteLine("Underben");
                    Debug.WriteLine("Koordinater: {0}, {1}", X, Y);
                    Location.BodyParts = LocationOnBody.BodyPart.Underben;

                    PointClicked = true;
                }
                else if ((X > 75 && X < 101 && Y > 438 && Y < 476) || (X > 112 && X < 137 && Y > 438 && Y < 476))
                {
                    Debug.WriteLine("Fod");
                    Debug.WriteLine("Koordinater: {0}, {1}", X, Y);
                    Location.BodyParts = LocationOnBody.BodyPart.Fod;

                    PointClicked = true;
                }
            }

            Collections.CollectionName = Location.BodyParts.ToString();
            return PointClicked;
        }

        #endregion


        #region FemaleBack
        public bool LocalizePointFemaleBack(bool PointClicked, int X, int Y)
        {
            if (Y < 211) //alt over hoften
            {
                if (X > 86 && X < 126 && Y > 0 && Y < 49)
                {
                    Debug.WriteLine("Baghoved");
                    Debug.WriteLine("Koordinater: {0}, {1}", X, Y);

                    Location.BodyParts = LocationOnBody.BodyPart.Baghoved;

                    PointClicked = true;
                }
                else if ((X > 83 && X < 88 && Y > 30 && Y < 42) || (X > 124 && X < 130 && Y > 30 && Y < 42))
                {
                    Debug.WriteLine("Øre");
                    Debug.WriteLine("Koordinater: {0}, {1}", X, Y);
                    Location.BodyParts = LocationOnBody.BodyPart.Øre;

                    PointClicked = true;
                }
                else if (X > 93 && X < 119 && Y > 49 && Y < 73)
                {
                    Debug.WriteLine("Nakke");
                    Debug.WriteLine("Koordinater: {0}, {1}", X, Y);
                    Location.BodyParts = LocationOnBody.BodyPart.Nakke;

                    PointClicked = true;
                }
                else if ((X > 52 && X < 79 && Y > 73 && Y < 106) || (X > 127 && X < 162 && Y > 73 && Y < 106))
                {
                    Debug.WriteLine("Bagskulder");
                    Debug.WriteLine("Koordinater: {0}, {1}", X, Y);
                    Location.BodyParts = LocationOnBody.BodyPart.Bagskulder;

                    PointClicked = true;
                }
                else if ((X > 51 && X < 73 && Y > 106 && Y < 165) || (X > 140 && X < 166 && Y > 106 && Y < 165))
                {
                    Debug.WriteLine("Overarm");
                    Debug.WriteLine("Koordinater: {0}, {1}", X, Y);
                    Location.BodyParts = LocationOnBody.BodyPart.Overarm;

                    PointClicked = true;
                }
                else if ((X > 22 && X < 58 && Y > 165 && Y < 226) || (X > 153 && X < 194 && Y > 165 && Y < 226))
                {
                    Debug.WriteLine("Underarm");
                    Debug.WriteLine("Koordinater: {0}, {1}", X, Y);
                    Location.BodyParts = LocationOnBody.BodyPart.Underarm;

                    PointClicked = true;
                }
                else if (X > 66 && X < 147 && Y > 73 && Y < 211)
                {
                    Debug.WriteLine("Ryg");
                    Debug.WriteLine("Koordinater: {0}, {1}", X, Y);
                    Location.BodyParts = LocationOnBody.BodyPart.Ryg;

                    PointClicked = true;
                }
                else if (X > 57 && X < 155 && Y > 211 && Y < 253)
                {
                    Debug.WriteLine("Balle");
                    Debug.WriteLine("Koordinater: {0}, {1}", X, Y);
                    Location.BodyParts = LocationOnBody.BodyPart.Balle;

                    PointClicked = true;
                }
                else if ((X > 59 && X < 104 && Y > 253 && Y < 318) || (X > 108 && X < 154 && Y > 253 && Y < 318))
                {
                    Debug.WriteLine("Baglår");
                    Debug.WriteLine("Koordinater: {0}, {1}", X, Y);
                    Location.BodyParts = LocationOnBody.BodyPart.Baglår;

                    PointClicked = true;
                }
                else if ((X > 72 && X < 103 && Y > 318 && Y < 351) || (X > 110 && X < 140 && Y > 318 && Y < 351))
                {
                    Debug.WriteLine("Knæhase");
                    Debug.WriteLine("Koordinater: {0}, {1}", X, Y);
                    Location.BodyParts = LocationOnBody.BodyPart.Knæhase;

                    PointClicked = true;
                }
                else if ((X > 70 && X < 101 && Y > 351 && Y < 438) || (X > 113 && X < 144 && Y > 351 && Y < 438))
                {
                    Debug.WriteLine("Læg");
                    Debug.WriteLine("Koordinater: {0}, {1}", X, Y);
                    Location.BodyParts = LocationOnBody.BodyPart.Læg;

                    PointClicked = true;
                }
                else if ((X > 62 && X < 100 && Y > 438 && Y < 476) || (X > 112 && X < 152 && Y > 438 && Y < 476))
                {
                    Debug.WriteLine("Fod");
                    Debug.WriteLine("Koordinater: {0}, {1}", X, Y);
                    Location.BodyParts = LocationOnBody.BodyPart.Fod;

                    PointClicked = true;
                }
            }

            else //alt under hoften
            {
                if ((X > 9 && X < 33 && Y > 226 && Y < 254) || (X > 179 && X < 201 && Y > 226 && Y < 254))
                {
                    Debug.WriteLine("Håndryg");
                    Debug.WriteLine("Koordinater: {0}, {1}", X, Y);
                    Location.BodyParts = LocationOnBody.BodyPart.Håndryg;

                    PointClicked = true;
                }
                else if ((X > 0 && X < 11 && Y > 233 && Y < 254) || (X > 202 && X < 211 && Y > 233 && Y < 254))
                {
                    Debug.WriteLine("Tommelfinger");
                    Debug.WriteLine("Koordinater: {0}, {1}", X, Y);
                    Location.BodyParts = LocationOnBody.BodyPart.Tommelfinger;

                    PointClicked = true;
                }
                else if ((X > 9 && X < 28 && Y > 254 && Y < 275) || (X > 184 && X < 203 && Y > 254 && Y < 275))
                {
                    Debug.WriteLine("Finger");
                    Debug.WriteLine("Koordinater: {0}, {1}", X, Y);
                    Location.BodyParts = LocationOnBody.BodyPart.Finger;

                    PointClicked = true;
                }
                else if (X > 57 && X < 155 && Y > 211 && Y < 253)
                {
                    Debug.WriteLine("Balle");
                    Debug.WriteLine("Koordinater: {0}, {1}", X, Y);
                    Location.BodyParts = LocationOnBody.BodyPart.Balle;

                    PointClicked = true;
                }
                else if ((X > 59 && X < 104 && Y > 253 && Y < 318) || (X > 108 && X < 154 && Y > 253 && Y < 318))
                {
                    Debug.WriteLine("Baglår");
                    Debug.WriteLine("Koordinater: {0}, {1}", X, Y);
                    Location.BodyParts = LocationOnBody.BodyPart.Baglår;

                    PointClicked = true;
                }
                else if ((X > 72 && X < 103 && Y > 318 && Y < 351) || (X > 110 && X < 140 && Y > 318 && Y < 351))
                {
                    Debug.WriteLine("Knæhase");
                    Debug.WriteLine("Koordinater: {0}, {1}", X, Y);
                    Location.BodyParts = LocationOnBody.BodyPart.Knæhase;

                    PointClicked = true;
                }
                else if ((X > 70 && X < 101 && Y > 351 && Y < 438) || (X > 113 && X < 144 && Y > 351 && Y < 438))
                {
                    Debug.WriteLine("Læg");
                    Debug.WriteLine("Koordinater: {0}, {1}", X, Y);
                    Location.BodyParts = LocationOnBody.BodyPart.Læg;

                    PointClicked = true;
                }
                else if ((X > 62 && X < 100 && Y > 438 && Y < 476) || (X > 112 && X < 152 && Y > 438 && Y < 476))
                {
                    Debug.WriteLine("Fod");
                    Debug.WriteLine("Koordinater: {0}, {1}", X, Y);
                    Location.BodyParts = LocationOnBody.BodyPart.Fod;

                    PointClicked = true;
                }
            }

            Collections.CollectionName = Location.BodyParts.ToString();
            return PointClicked;
        }

        #endregion
    }
}
