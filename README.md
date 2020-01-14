# AHpx-Process-Manager

**Code by [AHpx](http://blog.ahpxarctic.cn/)**<br/>
**Copyright 2017-2020 AHpx allrights reserved.**

[简体中文](http://blog.ahpxarctic.cn/)

## Describtion

A C# class library base on .NetFramework 4.8 and using Windows api to implement functions.

Function list:
<table>
  <tr>
    <th>Function</th>
	<th>Describe</th>
  </tr>
  <tr>
    <td>Suspend</td>
	<td>Suspend a process by its name</td>
  </tr>
  <tr>
    <td>Resume</td>
  	<td>Resume a process by its name after suspended</td>
  </tr>
  <tr>
    <td>Kill</td>
  	<td>Kill a process by its name</td>
  </tr>
  <tr>
    <td>Start</td>
  	<td>Start a process by its path("C:\X\x\xx\xx.exe")</td>
  </tr>
  <tr>
    <td>Change</td>
  	<td>Change a window by its process name</td>
  </tr>
  <tr>
    <td>ProcessExist</td>
  	<td>Get process exist state by its process name</td>
  </tr>
  <tr>
    <td>WindowExist</td>
  	<td>Get window exist state by its title text</td>
  </tr>
</table>

## Notioce

All process in this lib is only for name **without extension name** like "javaw" but not "javaw.exe"<br/>
~~(Maybe you can run **Minecraft** to find javaw.exe)~~
