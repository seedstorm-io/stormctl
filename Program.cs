using System;

/**
  ____                _ ____  _                         _
 / ___|  ___  ___  __| / ___|| |_ ___  _ __ _ __ ___   (_) ___
 \___ \ / _ \/ _ \/ _` \___ \| __/ _ \| '__| '_ ` _ \  | |/ _ \
  ___) |  __/  __/ (_| |___) | || (_) | |  | | | | | |_| | (_) |
 |____/ \___|\___|\__,_|____/ \__\___/|_|  |_| |_| |_(_)_|\___/

stormctl is the command line tool to manage your seedstorm.io account.

**/

namespace stormctl
{
    class Program
    {
        public static int Main(string[] args) => new StormCtl(args).Banner().Execute();
    }
}
