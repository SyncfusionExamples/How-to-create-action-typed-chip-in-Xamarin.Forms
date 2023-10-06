# How-to-create-a-Chips-sample
This repository sample explains how to create a chips sample in Xamarin.Forms 
# Getting Started with Chip sample
Step 1: Add the NuGet to the project and add the namespace as shown in the following code sample:

**[XAML]**

```
xmlns:buttons="clr-namespace:Syncfusion.XForms.Buttons;assembly=Syncfusion.Buttons.XForms"
```
**[C#]**

```
using Syncfusion.XForms.Buttons;
```
Step 2: Then initialize an empty SfChipGroup as shown in the following code:

**[XAML]**

```
<ContentPage.Content>
		<Grid>
			<buttons:SfChipGroup/>
		</Grid>
	</ContentPage.Content>
```
**[C#]**
```
public GettingStarted()
		{
			InitializeComponent();
			Grid grid = new Grid();
			grid.Children.Add(new SfChipGroup());
			this.Content = grid;
		}
```


# How-to-create-action-typed-chip-in-Xamarin.Forms
Action type of SfChipGroup, executes the [`Command`](https://help.syncfusion.com/xamarin/chips/customization#command) when clicking the chip in SfChipGroup. On its [`Command`](https://help.syncfusion.com/xamarin/chips/customization#command) action, we can do our desired action.

[`Command`](https://help.syncfusion.com/xamarin/chips/customization#command) will execute only for Action typed SfChipGroup.

![](action.gif)
