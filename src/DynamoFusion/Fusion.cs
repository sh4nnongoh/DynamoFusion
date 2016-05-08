﻿using Autodesk.DesignScript.Geometry;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FusionManagedWrapper;

// This is the Dynamo-Fusion node library for Fusion specific nodes in Dynamo
namespace DynamoFusion
{
    public class Fusion
    {
        public static FusionCurve ImportCurve(IEnumerable<Curve> curves)
        {
            var geometries = curves.ToArray();
            var circle = geometries[0] as Circle;
            FusionCurve entity = null;
            if (circle != null)
            {
                entity = ToFusionCurve(circle);
            }
            return entity;
        }

        private static FusionCurve ToFusionCurve(Curve curve)
        {
            var cv = curve as Circle;
            if(cv != null)
            {
                var point = cv.CenterPoint;
                return FusionCurve.createCircle(point.X, point.Y, point.Z, cv.Radius);
            }
            return null;
        }
    }
}
