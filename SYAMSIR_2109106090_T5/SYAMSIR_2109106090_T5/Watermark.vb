﻿Imports System.ComponentModel
Public Class Watermark
    Inherits TextBox
    'delacer a varibale
    Dim WaterText As String
    Dim WaterColor As Color
    Dim WaterFont As Font
    Dim WaterBrush As SolidBrush
    Dim WaterContainer As Panel
    Public Sub New()
        MyBase.New()
        StartProcess()
    End Sub
    Private Sub StartProcess()
        WaterText = "jjjj"
        WaterColor = Color.Gray
        '---------------------------------------------------------'
        WaterFont = New Font(Me.Font, FontStyle.Italic)
        '---------------------------------------------------------'
        WaterBrush = New SolidBrush(WaterColor)
        CreateWtermark()
        AddHandler TextChanged, AddressOf ChangeText
        AddHandler FontChanged, AddressOf ChangeFont
    End Sub
    Private Sub CreateWtermark()
        WaterContainer = New Panel
        Me.Controls.Add(WaterContainer)
        AddHandler WaterContainer.Click, AddressOf Cliked
        AddHandler WaterContainer.Paint, AddressOf Painted
    End Sub
    Private Sub RemoveWtermark()
        Me.Controls.Remove(WaterContainer)
    End Sub
    Private Sub ChangeText(sender As Object, e As EventArgs)
        If Me.TextLength <= 0 Then
            CreateWtermark()
        ElseIf Me.TextLength > 0 Then
            RemoveWtermark()
        End If
    End Sub
    Private Sub ChangeFont(sender As Object, e As EventArgs)
        WaterFont = New Font(Me.Font, FontStyle.Italic)
    End Sub
    Private Sub Cliked(sender As Object, e As EventArgs)
        Me.Focus()
    End Sub
    Private Sub Painted(sender As Object, e As PaintEventArgs)
        WaterContainer.Location = New Point(2, 0)
        WaterContainer.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        WaterContainer.Height = Me.Height
        WaterContainer.Width = Me.Width
        WaterBrush = New SolidBrush(WaterColor)
        Dim graphic As Graphics = e.Graphics
        graphic.DrawString(WaterText, WaterFont, WaterBrush, New PointF(-2.0!, 1.0!))
    End Sub
    Protected Overrides Sub oninvalidated(e As System.Windows.Forms.InvalidateEventArgs)
        MyBase.OnInvalidated(e)
        WaterContainer.Invalidate()
    End Sub
    <Category("Watermark Attributes"), Description("Sets Watermark Text")> Public Property WatermarkText As String
        Get
            Return WaterText
        End Get
        Set(value As String)
            WaterText = value
            Me.Invalidate()
        End Set
    End Property
    <Category("Watermark Attributes"), Description("Sets Watermark Color")> Public Property WatermarkColor As Color
        Get
            Return WaterColor
        End Get
        Set(value As Color)
            WaterColor = value
            Me.Invalidate()
        End Set
    End Property
End Class