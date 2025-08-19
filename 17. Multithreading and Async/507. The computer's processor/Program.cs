///
/// How the computer's processor works.
/// The computer's processor is also known as the central processing unit i.e. UPU
/// is brain of the computer.
/// Its job is to process instructions embedded within the programs.
/// The instructions that needs to be processed are put in queue and await their turn 
/// to be consumed by the processor. 
/// The processor can have one or more cores. Each core can process one instruction 
/// at a time. For now we will see processor with one core. 
/// The OS Windows, runs a special program called the scheduler.
/// Its job is to decide the order and time frames in which the processor will consume 
/// the instructions. Those time frames are known as the processor time slices.
/// They are the periods of time the processor will deal with a specific instruction.
/// Assume one instruction runs for 10 minutes then other instructions will have to 
/// wait for 10 minutes and computer will get completely frozen for that 10 minutes. 
/// We can not allow that to happen. So, scheduler gives each instruction only 
/// a small slice of the proecssor time.
/// For e.g. Assume that long instruction will be splited in to 2 and 
/// Part one runs then other instruction will run then part 2 will run.
/// So, in reality an instruction can not be finished in one time slice, it will
/// need to wait and be continued in the next one.
/// Thanks to this we can run multiple applications run simultaneously, even when 
/// using single core.
/// If the processor has multiple cores, some programs or different threads with in the 
/// same program can run parallelly at the same time.
/// Some instructions are more important that others.
/// So they have the higher priority, so they will run before low priority 
/// instructions.
///