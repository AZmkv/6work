﻿namespace Lab6_1
{
    public class Route
    {
        public string StartPoint { get; set; }
        public string EndPoint { get; set; }

        public Route(string startPoint, string endPoint)
        {
            StartPoint = startPoint;
            EndPoint = endPoint;
        }
    }
}
