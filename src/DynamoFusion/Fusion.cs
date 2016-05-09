﻿using Autodesk.DesignScript.Geometry;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FusionManagedWrapper;
using Autodesk.DesignScript.Runtime;
using Dynamo.Graph.Nodes;
using Dynamo.UI.Commands;
using Dynamo.Wpf;
using Dynamo.Controls;
using DynamoFusion.Controls;

// This is the Dynamo-Fusion node library for Fusion specific nodes in Dynamo
namespace DynamoFusion
{
    public static class Fusion
    {
        [IsVisibleInDynamoLibrary(false)]
        public static IEnumerable<FusionEntity> SelectEntity()
        {
            return FusionEntity.getSelectedEntities();
        }

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
            if (cv != null)
            {
                var point = cv.CenterPoint;
                return FusionCurve.createCircle(point.X, point.Y, point.Z, cv.Radius);
            }
            return null;
        }

        
    }

    
}