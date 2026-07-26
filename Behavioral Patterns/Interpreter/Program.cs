using Interpreter;

Mirror mirror = new Mirror("calc_winforms.xml");
Application.Run((Form)mirror.LastObject!);