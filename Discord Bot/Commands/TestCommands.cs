using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using DSharpPlus.CommandsNext;
using DSharpPlus.CommandsNext.Attributes;

namespace Bot.Commands
{
    public class TestCommands : BaseCommandModule
    {
        [Command("reminder")]
        public async Task MySecondCommand(CommandContext ctx)
        {
            await ctx.Channel.SendMessageAsync("drink water");
        }


        [Command("Hi")]
        public async Task reminder(CommandContext ctx)
        {
            await ctx.Channel.SendMessageAsync($"Hello {ctx.User.Username}");
        }
    }
}

