#if ! (UNITY_DASHBOARD_WIDGET || UNITY_WEBPLAYER || UNITY_WII || UNITY_WIIU || UNITY_NACL || UNITY_FLASH || UNITY_BLACKBERRY) // Disable under unsupported platforms.
//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.2
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public enum AkMeteringFlags {
  AK_NoMetering = 0,
  AK_EnableBusMeter_Peak = 1 << 0,
  AK_EnableBusMeter_TruePeak = 1 << 1,
  AK_EnableBusMeter_RMS = 1 << 2,
  AK_EnableBusMeter_KPower = 1 << 4,
  AK_EnableBusMeter_3DMeter = 1 << 5
}
#endif // #if ! (UNITY_DASHBOARD_WIDGET || UNITY_WEBPLAYER || UNITY_WII || UNITY_WIIU || UNITY_NACL || UNITY_FLASH || UNITY_BLACKBERRY) // Disable under unsupported platforms.