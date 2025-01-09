// I FROM SOLID PRINCIPLE -> Interface Segregation Principle (ISP)
///
/// No code should be forced to depend on methods it does not use.
/// We saw this exaplme which does not use this principle in the last lecture.
/// The last lecture issue can be solved by breaking ICollection interface into the 2 interfaces.
/// One will act as read only which will be implemented by Array.
/// 
/// Do not provide any stub implementation like they have done it Array class Add method.
/// Spend some time to create a better design instead of spending hours for tricky bugs in future.
/// Be careful before adding the new method in the interface.
///