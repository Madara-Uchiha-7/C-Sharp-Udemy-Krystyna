///
/// We will learn how to use breakpoints to debug programs we write.
/// We will also learn what QuickWatch window is and how to use it.
/// 
/// There is a better way of peeking at the value of some variable at a given moment i.e
/// while program is running.
/// For that, we can use breakpoints.
/// 
/// Click on this panel on the left hand side.
/// Alternatively, I can click anywhere on the line and press F9.
/// 
/// As you can see, a red dot appeared.
/// This dot is our breakpoint.
/// It stops the execution of a program right before this line is executed.
/// Thanks to that, we'll be able to look at our variables without printing them to the console.
/// 
/// Now if we want the program to move forward, but only by one line.
/// To move one step forward, we can either press F10 or click on top, the Step Over button.
/// 
/// When we are done with debugging and want the program to go on, we can click Continue button. Debugging
/// with Visual Studio Code is very similar.
/// 
/// 
/// Debugging with breakpoints is extremely useful. Whenever our program behaves in some weird way or gives
/// an error,
/// breakpoints allow us to trace its execution step-by-sstep, checking the values of variables on the way.
/// 
/// When debugging with breakpoints, we can inspect such objects much more easily.
/// We can hover over the varibale that we want to inspect.
/// Then select that variable or any expression like x + y,
/// and then press Shift + F9 or right click -> select quick watch.
/// 
/// The window that opened is called QuickWatch and here we can see the result of the expression I selected.
/// 
/// Within this window
/// we can test any expression we want, even if we hadn't written it in the code.
/// There is no exact equivalent of the QuickWatch window in Visual Studio Code, but here is what we can
/// instead.
/// 
/// We can simply write the expression we want to evaluate in the Debug Console which comes at
/// bottom when debugging starts.
/// 
/// ------------------
/// From 26. Comments lecture:
/// 
/// You can select multiple lines and select Ctrl + k + c
/// to comment.
/// And Ctrl + k +u
/// to uncomment.
/// 
/// If you hold the AlT and then drag up or down
/// then we can edit multiple places at the same time.
/// 
/// 