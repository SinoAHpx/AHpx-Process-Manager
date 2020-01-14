# AHpx-Process-Manager

**Code by [AHpx](http://blog.ahpxarctic.cn/)And OpenSource please follow MIT LICENSE**<br/>
**Copyright 2017-2020 AHpx allrights reserved.**

[简体中文](https://github.com/2933170747/AHpx-Process-Manager/blob/master/RAEAME_CN.md)

## Describtion

A C# class library base on .NetFramework 4.8 and using Windows api to implement functions.

Function list:
<table>
  <tr>
    <th>Function</th>
	<th>Describe</th>
  </tr>
  <tr>
    <td>SuspendProcess</td>
	<td>Suspend a process by its name</td>
  </tr>
  <tr>
    <td>ResumeProcess</td>
  	<td>Resume a process by its name after suspended</td>
  </tr>
  <tr>
    <td>KillProcess</td>
  	<td>Kill a process by its name</td>
  </tr>
  <tr>
    <td>StartProcess</td>
  	<td>Start a process by its path("C:\X\x\xx\xx.exe")</td>
  </tr>
  <tr>
    <td>ChangeWindow</td>
  	<td>Change a window by its process name</td>
  </tr>
  <tr>
    <td>IsProcessExist</td>
  	<td>Get process exist state by its process name</td>
  </tr>
  <tr>
    <td>IsWindowExist</td>
  	<td>Get window exist state by its title text</td>
  </tr>
</table>

## Notioce

All process in this lib is only for name **without extension name** like "javaw" but not "javaw.exe"<br/>
~~(Maybe you can run **Minecraft** to find javaw.exe)~~
