   M S B A M L   `   `   `  ????G  CKeySimulator, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:KeySimulatorKeySimulator  5   	       KeySimulator.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:KeySimulator     5   	     ? Title$  Settings??5   	   $	??450??6   $	??800??6'   .??5	      ?  ? RowDefinitions 5
   
   ?? 5      6   ?? 5      $??70 ?6   6*    ? ColumnDefinitions 5   
   ?? 5      6!   ?? 5      6!   ?? 5      6!   .+?5   
   ?? -   5         ??Name$ 	start_btn??5      $??1??6$   $??1??61   $??10q?6A   $
??Bold"?6M   .??6t   START6{   ?? 5   
   $
??Bold"?6   $??0??6#   $??10q?63   .??6?   Keys:6F   ?? 5   
   -   5        $??keyInput??5       ?? SelectedIndex$ 0??6#   $??80??65   $??20??6@   $
??Left=?6L   $	??Top=?6g   $??15 50q?6   .@?5      ?? .??6   
Spacebar6%   5      ?? 5   
   $
??Bold"?6   $??1??6#   $??10q?63   .??6?   Delay:6G   ?? 5   
   -   5        $??
delayInput??5      $??20??6%   $??80??61   $??1??6<   $
??Left=?6M   $	??Top=?6h   $??15 50q?6?   .??6?   56?   5      5      