﻿using System.Runtime.InteropServices;
using mshtml;

namespace DesignTE.View.NoteEditing.MsHtmlWrap
{
    /// <summary>
    /// Interface used for customizing editing behavior of MSHTML
    /// </summary>
    [ComImport]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    [Guid("3050f604-98b5-11cf-bb82-00aa00bdce0b")]
    public interface IHTMLCaretRaw
    {
        void MoveCaretToPointer(
            IDisplayPointerRaw pDispPointer,
            [MarshalAs(UnmanagedType.Bool)] bool fScrollIntoView,
            _CARET_DIRECTION eDir);

        void MoveCaretToPointerEx(
            IDisplayPointerRaw pDispPointer,
            [MarshalAs(UnmanagedType.Bool)] bool fVisible,
            [MarshalAs(UnmanagedType.Bool)] bool fScrollIntoView,
            _CARET_DIRECTION eDir);

        void MoveMarkupPointerToCaret(
            IMarkupPointerRaw pIMarkupPointer);

        void MoveDisplayPointerToCaret(
            IDisplayPointerRaw pDispPointer);

        void IsVisible(
            [Out, MarshalAs(UnmanagedType.Bool)] out bool pIsVisible);

        void Show(
            [MarshalAs(UnmanagedType.Bool)] bool fScrollIntoView);

        void Hide();

        void InsertText(
            [MarshalAs(UnmanagedType.LPWStr)] string pText,
            int lLen);

        void ScrollIntoView();

        void GetLocation(
            [Out] out POINT pPoint,
            [In, MarshalAs(UnmanagedType.Bool)] bool fTranslate);

        void GetCaretDirection(
            [Out] out _CARET_DIRECTION peDir);

        void SetCaretDirection(
            _CARET_DIRECTION eDir);
    }
}

