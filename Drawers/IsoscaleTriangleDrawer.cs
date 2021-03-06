﻿using System.Windows.Input;
using System.Windows;
using System.Windows.Ink;
using System;

namespace PaintWPF.Drawers
{
    class IsoscaleTriangleDrawer : Drawer
    {
        public override Stroke draw(Point anchor, Point cursor)
        {
            var pointCollection = new StylusPointCollection();

            pointCollection.Add(new StylusPoint(anchor.X, cursor.Y));
            pointCollection.Add(new StylusPoint((cursor.X + anchor.X) / 2, anchor.Y));
            pointCollection.Add(new StylusPoint(cursor.X, cursor.Y));
            pointCollection.Add(new StylusPoint(anchor.X, cursor.Y));

            var triangle = new Stroke(pointCollection);
            return triangle;
        }

        public IsoscaleTriangleDrawer() : base () { }
    }
}
