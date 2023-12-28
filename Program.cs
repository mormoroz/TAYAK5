using lab5;

var PushdownAutomaton = new CBASInterpreter(@"/Users/aleksandermorozov/MIET/TAYAK/new/kaef/TAYAK/Lab5/test2.txt");

var program = File.ReadAllText(@"/Users/aleksandermorozov/MIET/TAYAK/new/kaef/TAYAK/Lab5/program.txt");
PushdownAutomaton.Interpret(program);
