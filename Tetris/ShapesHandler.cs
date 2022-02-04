using System;
using System.Drawing;

namespace Tetris
{
    static class ShapesHandler
    {
        private static Shape[] shapesArray;
        static ShapesHandler()
        {
            shapesArray = new Shape[]
                {
                    new Shape {
                        Width = 2,
                        Height = 2,
                        Position = new int[,]
                        {
                            { 1, 1 },
                            { 1, 1 }
                        },
                        Color = Brushes.Pink,
                    },
                    new Shape {
                        Width = 1,
                        Height = 4,
                        Position = new int[,]
                        {
                            { 1 },
                            { 1 },
                            { 1 },
                            { 1 }
                        },
                        Color = Brushes.Plum,
                    },
                    new Shape {
                        Width = 3,
                        Height = 2,
                        Position = new int[,]
                        {
                            { 0, 1, 0 },
                            { 1, 1, 1 }
                        },
                        Color = Brushes.HotPink,
                    },
                    new Shape {
                        Width = 3,
                        Height = 2,
                        Position = new int[,]
                        {
                            { 0, 0, 1 },
                            { 1, 1, 1 }
                        },
                        Color = Brushes.PaleVioletRed,
                    },
                    new Shape {
                        Width = 3,
                        Height = 2,
                        Position = new int[,]
                        {
                            { 1, 0, 0 },
                            { 1, 1, 1 }
                        },
                        Color = Brushes.CornflowerBlue,
                    },
                    new Shape {
                        Width = 3,
                        Height = 2,
                        Position = new int[,]
                        {
                            { 1, 1, 0 },
                            { 0, 1, 1 }
                        },
                        Color = Brushes.Crimson,
                    },
                    new Shape {
                        Width = 3,
                        Height = 2,
                        Position = new int[,]
                        {
                            { 0, 1, 1 },
                            { 1, 1, 0 }
                        },
                        Color = Brushes.RoyalBlue,
                    }
                };
        }
        
        public static Shape GetRandomShape()
        {
            var shape = shapesArray[new Random().Next(shapesArray.Length)];

            return shape;
        }
    }
}
