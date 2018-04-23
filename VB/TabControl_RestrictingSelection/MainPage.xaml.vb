Imports Microsoft.VisualBasic
Imports System.Windows
Imports System.Windows.Controls
Imports DevExpress.Xpf.Core
Imports DXExample.DemoData

Namespace TabControl_RestrictingSelection
	Partial Public Class MainPage
		Inherits UserControl
		Public Sub New()
			InitializeComponent()
		End Sub
		Private Sub LayoutRoot_Loaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
			tabControl.ItemsSource = Invoice.GetData()
		End Sub
		Private Sub tabControl_SelectionChanging(ByVal sender As Object, ByVal e As TabControlSelectionChangingEventArgs)
				If Not(CType(tabControl.Items(tabControl.SelectedIndex), Invoice)).IsUrgent Then
					e.Cancel = True
				End If
		End Sub
	End Class
End Namespace
