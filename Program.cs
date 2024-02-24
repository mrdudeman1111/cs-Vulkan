using System.Numerics;
using System.Reflection.Metadata;
using Silk.NET.Core.Contexts;
using Silk.NET.Maths;
using Silk.NET.Vulkan;
using Silk.NET.Windowing;

namespace Sandbox
{
  class Proc
  {

    private IWindow? wnd;
    private Vk? vulkan;

    private Instance? vkInst;
    private PhysicalDevice? vkPhysicalDevice;
    private Device? vkDev;
    private Queue? vkGraphicsQueue;
    private CommandPool? vkGraphicsPool;
    private CommandBuffer? vkGraphicsBuffer;
    private IVkSurface? vkRenderSurface;
    private SwapchainKHR? vkSwapchain;
    private RenderPass? vkRenderpass;
    private ShaderModule? VertexShader;
    private ShaderModule? FragmentShader;
    private Pipeline? vkPipeline;


    public void InitVulkan()
    {
      var Options = WindowOptions.DefaultVulkan;
      Options.Size = new Vector2D<int>(1280, 720);
      Options.Title = "cs Renderer";

      wnd = Window.Create(Options);
      wnd.Initialize();

      if(wnd.VkSurface == null)
      {
        throw new Exception("Windowing system failed to init with vulkan support. (no presentable Surface available)");
      }
    }

    private void InitInstance()
    {
      InstanceCreateInfo instCI = new InstanceCreateInfo();
      instCI.SType = StructureType.InstanceCreateInfo;
      instCI.EnabledLayerCount = 1;

      vulkan.CreateInstance()
    }
  }
}

