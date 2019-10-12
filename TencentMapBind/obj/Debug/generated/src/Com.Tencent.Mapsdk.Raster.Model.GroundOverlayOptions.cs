using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Tencent.Mapsdk.Raster.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='GroundOverlayOptions']"
	[global::Android.Runtime.Register ("com/tencent/mapsdk/raster/model/GroundOverlayOptions", DoNotGenerateAcw=true)]
	public sealed partial class GroundOverlayOptions : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/tencent/mapsdk/raster/model/GroundOverlayOptions", typeof (GroundOverlayOptions));
		internal static new IntPtr class_ref {
			get {
				return _members.JniPeerType.PeerReference.Handle;
			}
		}

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override IntPtr ThresholdClass {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		internal GroundOverlayOptions (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='GroundOverlayOptions']/constructor[@name='GroundOverlayOptions' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe GroundOverlayOptions ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "()V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, null);
			} finally {
			}
		}

		public unsafe float AnchorU {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='GroundOverlayOptions']/method[@name='getAnchorU' and count(parameter)=0]"
			[Register ("getAnchorU", "()F", "GetGetAnchorUHandler")]
			get {
				const string __id = "getAnchorU.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe float AnchorV {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='GroundOverlayOptions']/method[@name='getAnchorV' and count(parameter)=0]"
			[Register ("getAnchorV", "()F", "GetGetAnchorVHandler")]
			get {
				const string __id = "getAnchorV.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe float Bearing {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='GroundOverlayOptions']/method[@name='getBearing' and count(parameter)=0]"
			[Register ("getBearing", "()F", "GetGetBearingHandler")]
			get {
				const string __id = "getBearing.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe global::Com.Tencent.Mapsdk.Raster.Model.LatLngBounds Bounds {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='GroundOverlayOptions']/method[@name='getBounds' and count(parameter)=0]"
			[Register ("getBounds", "()Lcom/tencent/mapsdk/raster/model/LatLngBounds;", "GetGetBoundsHandler")]
			get {
				const string __id = "getBounds.()Lcom/tencent/mapsdk/raster/model/LatLngBounds;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.LatLngBounds> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe float Height {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='GroundOverlayOptions']/method[@name='getHeight' and count(parameter)=0]"
			[Register ("getHeight", "()F", "GetGetHeightHandler")]
			get {
				const string __id = "getHeight.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe global::Com.Tencent.Mapsdk.Raster.Model.BitmapDescriptor Image {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='GroundOverlayOptions']/method[@name='getImage' and count(parameter)=0]"
			[Register ("getImage", "()Lcom/tencent/mapsdk/raster/model/BitmapDescriptor;", "GetGetImageHandler")]
			get {
				const string __id = "getImage.()Lcom/tencent/mapsdk/raster/model/BitmapDescriptor;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.BitmapDescriptor> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe bool IsVisible {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='GroundOverlayOptions']/method[@name='isVisible' and count(parameter)=0]"
			[Register ("isVisible", "()Z", "GetIsVisibleHandler")]
			get {
				const string __id = "isVisible.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe global::Com.Tencent.Mapsdk.Raster.Model.LatLng Location {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='GroundOverlayOptions']/method[@name='getLocation' and count(parameter)=0]"
			[Register ("getLocation", "()Lcom/tencent/mapsdk/raster/model/LatLng;", "GetGetLocationHandler")]
			get {
				const string __id = "getLocation.()Lcom/tencent/mapsdk/raster/model/LatLng;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.LatLng> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe float Transparency {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='GroundOverlayOptions']/method[@name='getTransparency' and count(parameter)=0]"
			[Register ("getTransparency", "()F", "GetGetTransparencyHandler")]
			get {
				const string __id = "getTransparency.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe float Width {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='GroundOverlayOptions']/method[@name='getWidth' and count(parameter)=0]"
			[Register ("getWidth", "()F", "GetGetWidthHandler")]
			get {
				const string __id = "getWidth.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe float ZIndex {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='GroundOverlayOptions']/method[@name='getZIndex' and count(parameter)=0]"
			[Register ("getZIndex", "()F", "GetGetZIndexHandler")]
			get {
				const string __id = "getZIndex.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='GroundOverlayOptions']/method[@name='anchor' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='float']]"
		[Register ("anchor", "(FF)Lcom/tencent/mapsdk/raster/model/GroundOverlayOptions;", "")]
		public unsafe global::Com.Tencent.Mapsdk.Raster.Model.GroundOverlayOptions Anchor (float p0, float p1)
		{
			const string __id = "anchor.(FF)Lcom/tencent/mapsdk/raster/model/GroundOverlayOptions;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.GroundOverlayOptions> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='GroundOverlayOptions']/method[@name='bearing' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("bearing", "(F)Lcom/tencent/mapsdk/raster/model/GroundOverlayOptions;", "")]
		public unsafe global::Com.Tencent.Mapsdk.Raster.Model.GroundOverlayOptions InvokeBearing (float p0)
		{
			const string __id = "bearing.(F)Lcom/tencent/mapsdk/raster/model/GroundOverlayOptions;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.GroundOverlayOptions> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='GroundOverlayOptions']/method[@name='image' and count(parameter)=1 and parameter[1][@type='com.tencent.mapsdk.raster.model.BitmapDescriptor']]"
		[Register ("image", "(Lcom/tencent/mapsdk/raster/model/BitmapDescriptor;)Lcom/tencent/mapsdk/raster/model/GroundOverlayOptions;", "")]
		public unsafe global::Com.Tencent.Mapsdk.Raster.Model.GroundOverlayOptions InvokeImage (global::Com.Tencent.Mapsdk.Raster.Model.BitmapDescriptor p0)
		{
			const string __id = "image.(Lcom/tencent/mapsdk/raster/model/BitmapDescriptor;)Lcom/tencent/mapsdk/raster/model/GroundOverlayOptions;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.GroundOverlayOptions> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='GroundOverlayOptions']/method[@name='position' and count(parameter)=2 and parameter[1][@type='com.tencent.mapsdk.raster.model.LatLng'] and parameter[2][@type='float']]"
		[Register ("position", "(Lcom/tencent/mapsdk/raster/model/LatLng;F)Lcom/tencent/mapsdk/raster/model/GroundOverlayOptions;", "")]
		public unsafe global::Com.Tencent.Mapsdk.Raster.Model.GroundOverlayOptions Position (global::Com.Tencent.Mapsdk.Raster.Model.LatLng p0, float p1)
		{
			const string __id = "position.(Lcom/tencent/mapsdk/raster/model/LatLng;F)Lcom/tencent/mapsdk/raster/model/GroundOverlayOptions;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.GroundOverlayOptions> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='GroundOverlayOptions']/method[@name='position' and count(parameter)=3 and parameter[1][@type='com.tencent.mapsdk.raster.model.LatLng'] and parameter[2][@type='float'] and parameter[3][@type='float']]"
		[Register ("position", "(Lcom/tencent/mapsdk/raster/model/LatLng;FF)Lcom/tencent/mapsdk/raster/model/GroundOverlayOptions;", "")]
		public unsafe global::Com.Tencent.Mapsdk.Raster.Model.GroundOverlayOptions Position (global::Com.Tencent.Mapsdk.Raster.Model.LatLng p0, float p1, float p2)
		{
			const string __id = "position.(Lcom/tencent/mapsdk/raster/model/LatLng;FF)Lcom/tencent/mapsdk/raster/model/GroundOverlayOptions;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (p2);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.GroundOverlayOptions> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='GroundOverlayOptions']/method[@name='positionFromBounds' and count(parameter)=1 and parameter[1][@type='com.tencent.mapsdk.raster.model.LatLngBounds']]"
		[Register ("positionFromBounds", "(Lcom/tencent/mapsdk/raster/model/LatLngBounds;)Lcom/tencent/mapsdk/raster/model/GroundOverlayOptions;", "")]
		public unsafe global::Com.Tencent.Mapsdk.Raster.Model.GroundOverlayOptions PositionFromBounds (global::Com.Tencent.Mapsdk.Raster.Model.LatLngBounds p0)
		{
			const string __id = "positionFromBounds.(Lcom/tencent/mapsdk/raster/model/LatLngBounds;)Lcom/tencent/mapsdk/raster/model/GroundOverlayOptions;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.GroundOverlayOptions> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='GroundOverlayOptions']/method[@name='putGroundOverlayOptions' and count(parameter)=3 and parameter[1][@type='com.tencent.mapsdk.raster.model.LatLng'] and parameter[2][@type='float'] and parameter[3][@type='float']]"
		[Register ("putGroundOverlayOptions", "(Lcom/tencent/mapsdk/raster/model/LatLng;FF)Lcom/tencent/mapsdk/raster/model/GroundOverlayOptions;", "")]
		protected unsafe global::Com.Tencent.Mapsdk.Raster.Model.GroundOverlayOptions PutGroundOverlayOptions (global::Com.Tencent.Mapsdk.Raster.Model.LatLng p0, float p1, float p2)
		{
			const string __id = "putGroundOverlayOptions.(Lcom/tencent/mapsdk/raster/model/LatLng;FF)Lcom/tencent/mapsdk/raster/model/GroundOverlayOptions;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (p2);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.GroundOverlayOptions> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='GroundOverlayOptions']/method[@name='transparency' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("transparency", "(F)Lcom/tencent/mapsdk/raster/model/GroundOverlayOptions;", "")]
		public unsafe global::Com.Tencent.Mapsdk.Raster.Model.GroundOverlayOptions InvokeTransparency (float p0)
		{
			const string __id = "transparency.(F)Lcom/tencent/mapsdk/raster/model/GroundOverlayOptions;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.GroundOverlayOptions> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='GroundOverlayOptions']/method[@name='visible' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("visible", "(Z)Lcom/tencent/mapsdk/raster/model/GroundOverlayOptions;", "")]
		public unsafe global::Com.Tencent.Mapsdk.Raster.Model.GroundOverlayOptions Visible (bool p0)
		{
			const string __id = "visible.(Z)Lcom/tencent/mapsdk/raster/model/GroundOverlayOptions;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.GroundOverlayOptions> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='GroundOverlayOptions']/method[@name='zIndex' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("zIndex", "(F)Lcom/tencent/mapsdk/raster/model/GroundOverlayOptions;", "")]
		public unsafe global::Com.Tencent.Mapsdk.Raster.Model.GroundOverlayOptions InvokeZIndex (float p0)
		{
			const string __id = "zIndex.(F)Lcom/tencent/mapsdk/raster/model/GroundOverlayOptions;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.GroundOverlayOptions> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
