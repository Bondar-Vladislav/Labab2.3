// dllmain.cpp : Определяет точку входа для приложения DLL.
#include "pch.h"
#include <windows.h>
#include <cstdio>
#include "combaseapi.h"

BOOL APIENTRY DllMain( HMODULE hModule,
                       DWORD  ul_reason_for_call,
                       LPVOID lpReserved
                     )
{
    switch (ul_reason_for_call)
    {
    case DLL_PROCESS_ATTACH:
    case DLL_THREAD_ATTACH:
    case DLL_THREAD_DETACH:
    case DLL_PROCESS_DETACH:
        break;
    }
    return TRUE;
}

wchar_t Str[] = L"y=x^3+5x^2-20x";

extern "C"
{
    __declspec(dllexport) double __cdecl TheFunc(double x)
    {
        return x * x * x + 5 * x * x - 20 * x;
    }
}
extern "C"
{
    __declspec(dllexport) wchar_t* __stdcall FuncName()
    {
        return Str;
    }
}