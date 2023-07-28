// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GLib {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class Mutex : GLib.Opaque {

		[DllImport (Global.GLibNativeDll, CallingConvention = CallingConvention.Cdecl)]
		static extern void g_mutex_clear(IntPtr raw);

		public void Clear() {
			g_mutex_clear(Handle);
		}

		[DllImport (Global.GLibNativeDll, CallingConvention = CallingConvention.Cdecl)]
		static extern void g_mutex_init(IntPtr raw);

		public void Init() {
			g_mutex_init(Handle);
		}

		[DllImport (Global.GLibNativeDll, CallingConvention = CallingConvention.Cdecl)]
		static extern void g_mutex_lock(IntPtr raw);

		public void Lock() {
			g_mutex_lock(Handle);
		}

		[DllImport (Global.GLibNativeDll, CallingConvention = CallingConvention.Cdecl)]
		static extern bool g_mutex_trylock(IntPtr raw);

		public bool Trylock() {
			bool raw_ret = g_mutex_trylock(Handle);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport (Global.GLibNativeDll, CallingConvention = CallingConvention.Cdecl)]
		static extern void g_mutex_unlock(IntPtr raw);

		public void Unlock() {
			g_mutex_unlock(Handle);
		}

		public Mutex(IntPtr raw) : base(raw) {}

#endregion
	}
}
