import torch

from torch.autograd import Variable

tensor = torch.FloatTensor([[1, 2], [3, 4]])
variable = Variable(tensor, requires_grad=True)

print(tensor)
print(variable)

t_out = torch.mean(tensor * tensor)
v_out = torch.mean(variable * variable)

print('\ntensor square: ', t_out,
      '\nvariable square:', v_out
      )

v_out.backward()
print('\ngrad of variable:', variable.grad)

print('\nvariable data in tensor form:', variable.data,
      '\nvariable data in numpy from:', variable.data.numpy()
      )
