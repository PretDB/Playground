import torch
import numpy as np

data = [-1, -2, 1, 2]

tensor = torch.FloatTensor(data)

print('\nabs',
      '\nnumpy:', np.abs(data),
      '\ntorch:', torch.abs(tensor)
      )

print('\nsin',
      '\nnumpy:', np.sin(data),
      '\ntorch:', torch.sin(tensor)
      )

print('\nmean',
      '\nnumpy:', np.mean(data),
      '\ntorch:', torch.mean(tensor)
      )

print('\nmatrix operation')

mat = [[1, 2], [3, 4]]

tensor = torch.FloatTensor(mat)

print('\nmatix mul',
      '\nnumpy:',np.matmul(mat, mat),
      '\ntorch:', torch.mm(tensor, tensor)
      )

data = np.array(mat)
print('\ndot',
      '\nnumpy:', data.dot(data),
      '\ntorch wrong way: tensor.dot(tensor)',
      '\ntorch right way: torch.dot(tensor.dot(tensor))'
      )
