# AHpx-Process-Manager


**本库由[AHpx](http://blog.ahpxarctic.cn/)开发并开放源代码，请注意遵守MIT协议。**<br/>
**Copyright 2017-2020 AHpx allrights reserved.**

## 简介


一个基于.NetFramework 4.8且使用Windows api来实现功能的C#类库。

功能列表:
<table>
  <tr>
    <th>功能</th>
	  <th>描述</th>
  </tr>
  <tr>
    <td>挂起进程(SuspendProcess)</td>
	<td>挂起一个指定名称的进程</td>
  </tr>
  <tr>
    <td>恢复进程(ResumeProcess)</td>
  	<td>恢复一个指定名称的进程，在挂起之后</td>
  </tr>
  <tr>
    <td>结束进程(KillProcess)</td>
  	<td>结束一个指定名称的进程</td>
  </tr>
  <tr>
    <td>运行进程(StartProcess)</td>
  	<td>运行一个进程，如("C:\X\x\xx\xx.exe")</td>
  </tr>
  <tr>
    <td>修改窗口标题(ChangeWindow)</td>
  	<td>修改指定进程的窗口标题，如果它有的话，本方法有两个重载：单String和Strings数组</td>
  </tr>
  <tr>
    <td>判断进程是否存在(IsProcessExist)</td>
  	<td>根据进程名称判断指定进程是否存在</td>
  </tr>
  <tr>
    <td>判断窗口是否存在(IsWindowExist)</td>
  	<td>根据窗口标题判断指定窗口是否存在</td>
  </tr>
</table>

## 注意


本库的所以进程名称都只需要名称而无需拓展名，如"javaw"而不是"javaw.exe"</br>
~~(也许你可以通过启动Minecraft来找到例子中的javaw)~~
