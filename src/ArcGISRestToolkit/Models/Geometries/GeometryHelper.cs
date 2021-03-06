﻿namespace ArcGISRestToolkit.Models.Geometries
{
	public enum GeometryTypes
	{
		Point,
		Multipoint,
		Polyline,
		Polygon,
		Envelope
	}

	public static class GeometryHelper
	{
		private const string POINT_GEOMETRY = "esriGeometryPoint";
		private const string MULTIPOINT_GEOMETRY = "esriGeometryMultipoint";
		private const string POLYLINE_GEOMETRY = "esriGeometryPolyline";
		private const string POLYGON_GEOMETRY = "esriGeometryPolygon";
		private const string ENVELOPE_GEOMETRY = "esriGeometryEnvelope";

		public static string GetGeometryTypeName(this GeometryTypes geometryType)
		{
			switch (geometryType)
			{
				case GeometryTypes.Point:
				{
					return POINT_GEOMETRY;
				}
				case GeometryTypes.Multipoint:
				{
					return MULTIPOINT_GEOMETRY;
				}
				case GeometryTypes.Polyline:
				{
					return POLYLINE_GEOMETRY;
				}
				case GeometryTypes.Polygon:
				{
					return POLYGON_GEOMETRY;
				}
				case GeometryTypes.Envelope:
				{
					return ENVELOPE_GEOMETRY;
				}
				default:
				{
					return null;
				}
			}
		}

		public static GeometryTypes GetGeometryType(this string geometryTypeName)
		{
			switch (geometryTypeName)
			{
				case POINT_GEOMETRY:
					{
						return GeometryTypes.Point;
					}
				case MULTIPOINT_GEOMETRY:
					{
						return GeometryTypes.Multipoint;
					}
				case POLYLINE_GEOMETRY:
					{
						return GeometryTypes.Polyline;
					}
				case POLYGON_GEOMETRY:
					{
						return GeometryTypes.Polygon;
					}
				case ENVELOPE_GEOMETRY:
					{
						return GeometryTypes.Envelope;
					}
				default:
					{
						return GeometryTypes.Point;
					}
			}
		}
	}
}
